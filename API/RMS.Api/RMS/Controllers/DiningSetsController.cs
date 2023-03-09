using Microsoft.AspNetCore.Mvc;
using RMS.Api.Core.Contracts;
using RMS.Api.Core.Models;
using RMS.Api.Infrastructure.Context;
using RMS.Api.Infrastructure.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RMS.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class DiningSetsController : ControllerBase
	{
        private readonly IDiningSetRepository _repository;

        public DiningSetsController(IDiningSetRepository repository)
        {
            _repository = repository;
        }
        // GET: api/<DiningSetsController>
        [HttpGet]
		[Route("/GetDiningSets")]
		public List<DiningSet> GetDiningSets()
		{
			return _repository.GetAllDiningSet();

		}

		// GET api/<DiningSetsController>/5
		[HttpGet("/GetDininigSetById/{id}")]
		public ActionResult GetDininigSet(int id)
		{
			if (_repository.GetDiningSetById(id)==null)
			{
				return NotFound();
			}
			var DiningSet = _repository.GetDiningSetById(id);
			return Ok(DiningSet);
		}

		// POST api/<DiningSetsController>
		[HttpPost("/AddDiningSet")]
		public ActionResult AddDiningSet([FromBody] DiningSet value)
		{
			try
			{
				_repository.AddDiningSet(value);
				return Ok();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return BadRequest();
			}
		}

		// PUT api/<DiningSetsController>/5
		[HttpPut("/UpdateDiningSet/{id}")]
		public ActionResult UpdateDiningSet(int id, [FromBody] DiningSet value)
		{
			try
			{
				if (_repository.GetDiningSetById(id)==null)
				{
					return NotFound();
				}
				_repository.UpdateDiningSet(id, value);
				return Ok();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return BadRequest();
			}
		}

		// DELETE api/<DiningSetsController>/5
		[HttpDelete("/DeleteDiningSet/{id}")]
		public ActionResult DeleteDiningSet(int id)
		{
			try
			{
				if (_repository.GetDiningSetById(id)==null)
				{
					return NotFound();
				}
				_repository.DeleteDiningSet(id);
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex);
			}
		}
	}
}
