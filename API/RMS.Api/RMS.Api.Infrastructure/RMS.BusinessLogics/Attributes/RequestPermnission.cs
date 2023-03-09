using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RMS.Api.Infrastructure.Attributes
{
	[AttributeUsage(AttributeTargets.Method)]
	public class RequiredPermissionAttribute : Attribute, IAuthorizationFilter
	{
		public string? Permission { get; set; }	
		
		public void OnAuthorization(AuthorizationFilterContext filterContext)
		{
			//base.OnAuthorization(actionContext);
			List<string> permissions = new List<string>() { "GetCustomer", "GetCustomerById" };
			if(!permissions.Contains(Permission)) 
			{
				filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Not Authorized";
				return;
			}
			else
			{
				filterContext.HttpContext.Response.Headers.Add("AuthStatus", "Authorized");
				return;
			}
		}

	}
	
}

