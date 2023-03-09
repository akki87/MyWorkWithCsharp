using Microsoft.AspNetCore.Mvc;
using RMS.Api.Core.Contracts;
using RMS.Api.Core.Models;
using RMS.Api.Core.RequestAndResonse;
using RMS.Api.Core.Responses;
using RMS.Api.Infrastructure.Attributes;
using RMS.Api.Infrastructure.Data.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RMS.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly ICustomerRepository _obj;
		public CustomersController(ICustomerRepository repository)
		{
			_obj = repository;
		}

		[HttpGet]
		[Route("/GetCustomers/{id:int?}")]
		//[CustomAuthorization("GetCustomer")]
		public async Task<ActionResult> Get([FromQuery] CustomerRequest? request)
		{
			CustomerResponse? customerResponse = new CustomerResponse();
			try
			{
				var result = (await _obj.GetAllCustomers(request.PageNumber, request.PageSize, request.SortOrder, request.SortBy)).ToList();
				if (result!=null)
				{
					customerResponse.CustomerList = result;
					customerResponse.TotalRecords = _obj.CustomersCount;
					customerResponse.PageNumber=request.PageNumber;
					customerResponse.PageSize=request.PageSize;
				}
				else
				{
					customerResponse=null;
				}
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}	
			return customerResponse!= null ? Ok(customerResponse) : NotFound(); 
		}

		// GET api/<CustomersController>/5
		[HttpGet("/GetCustomerById/{id:int?}")]
		//[CustomAuthorization("GetCustomerByID")]
		public async Task<ActionResult> GetCustomerByIDAsync(int id=9456)
		{
			var result = await _obj.GetCustomerById(id);
			if (result==null)
			{
				return NotFound();
			}
			return Ok(result);
		}
		[HttpGet("/GetCustomerByMobileNumber/{MobileNumber?}")]
		public async Task<ActionResult> GetCustomerByMobileNumberAsync(string MobileNumber="8639248231")
		{
			var res = await _obj.GetCustomerByMobileNumber(MobileNumber);
			if (res==null)
			{
				return NotFound();
			}
			return Ok(res);
		}

		// POST api/<CustomersController>
		[HttpPost]
		[Route("/AddCustomer")]
		//[CustomAuthorization("AddCustomer")]
		public async Task<ActionResult> AddCustomerAsync([FromBody] Customer value)
		{
			try
			{
				await _obj.AddCustomer(value);
				return Ok();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return BadRequest();
			}
		}

		[HttpPut("/UpdateCustomer/{id}")]
		//[CustomAuthorization("UpdateCustomer")]
		public async Task<ActionResult> UpdateCustomerAsync(int id, [FromBody] Customer value)
		{
			if (value==null)
			{
				return BadRequest();
			}
			if (!ModelState.IsValid) { return BadRequest(); }
			try
			{
				if (await _obj.GetCustomerById(id)==null)
				{
					return NotFound();
				}
				await _obj.UpdateCustomer(id, value);
				return Ok();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return BadRequest();
			}
		}

		// DELETE api/<CustomersController>/5
		[HttpDelete("/DeleteCustomer/{id}")]
		//[CustomAuthorization("DeleteCustomer")]
		public async Task<ActionResult> DeleteCustomerAsync(int id)
		{
			try
			{
				if (await _obj.GetCustomerById(id)==null)
				{
					return NotFound();
				}
				await _obj.RemoveCustomer(id);
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex);
			}
		}
	}
}
