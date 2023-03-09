using Couchbase.Management.Users;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RMS.Api.Infrastructure.Data.Context;
using RMS.Api.Infrastructure.Validations;
using System.Net;
using System.Text;

namespace RMS.Api.Infrastructure.Attributes
{
	[AttributeUsage(AttributeTargets.All)]
	public class CustomAuthorization : Attribute, IAuthorizationFilter
	{
		public string Authorization { get; set; }
		public string message { get; set; }
		public static RMSContext context = new RMSContext();
		private UserValidation _userValidation = new UserValidation(context);
		public CustomAuthorization(string permission)
		{
			Authorization = permission;
			
		}
		
		/// <summary>  
		/// This will Authorize User  
		/// </summary>  
		/// <returns></returns>  
		public  void OnAuthorization(AuthorizationFilterContext filterContext)
		{
			
			if (filterContext != null)
			{
				string? authToken;
				authToken = filterContext.HttpContext.Request.Headers["Authorization"].ToString().Length > 5 ?
					filterContext.HttpContext.Request.Headers["Authorization"].ToString().Substring(6) : null;
				if (authToken != null && authToken!="")
				{
					//string authToken = _token;
					if (authToken != null )
					{
						if (IsValidToken(authToken))
						{
							//filterContext.HttpContext.Response.Headers.Add("authToken", authToken);
							filterContext.HttpContext.Response.Headers.Add("AuthStatus", "Authorized");
							filterContext.HttpContext.Response.Headers.Add("storeAccessiblity", "Authorized");
							return;
						}
						else
						{
							//filterContext.HttpContext.Response.Headers.Add("authToken", authToken);
							filterContext.HttpContext.Response.Headers.Add("AuthStatus", message);
							filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
							filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = message;
							filterContext.Result = new JsonResult(message)
							{
								Value = new
								{
									Status = "Error",
									Message = message
								},
							};
						}
					}
				}
				else
				{
					filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.ExpectationFailed;
					filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Please Provide Login Credentials";
					filterContext.Result = new JsonResult("Please Provide Login Credentials")
					{
						Value = new
						{
							Status = "Error",
							Message = "Please Provide Login Credentials"
						},
					};
				}
			}
		}
		public bool IsValidToken(string authToken)
		{
			string[] credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authToken)).Split(':');
			try
			{
				_userValidation.Validate(credentials[0], credentials[1], Authorization);
				//userValidation.Validate(credentials[0], credentials[1],Authorization);
				return true;
			}
			catch(UserNotFoundException ex)
			{
				message= ex.Message;
				return false;
			}
			catch(InvalidPasswordException ex)
			{
				message= ex.Message;
				return false;
			}
			catch(NoPrivilegesFoundException ex)
			{
				message= ex.Message;
				return false;
			}
			catch(NoAuthorizationFoundException ex)
			{
				message= ex.Message;
				return false;
			}
			catch(Exception ex)
			{
				message= ex.Message;
				return false;
			}
		}
	}
}
