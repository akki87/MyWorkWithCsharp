using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Api.Core.ConfigModels;
using RMS.Api.Core.Contracts;

namespace RMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ICustomerRepository _customerRepository;
        public ConfigurationController(IConfiguration configuration,ICustomerRepository customerRepository)
        {
            _configuration = configuration;
            _customerRepository = customerRepository;
        }
        /// <summary>
        /// Read connection string values from IConfiguration by using GetValue and GetConnectionString methods
        /// </summary>
        /// <returns></returns>
        [HttpGet("connectionstrings")]
        public ActionResult GetConnectionStringsFromAppsettingConfig()
        {
            //var connectionString1 = _configuration.GetValue<string>("ConnectionStrings:RMSDbConnection");
            //var connectionString = _configuration.GetConnectionString("RMSDbConnection");
            var a = _customerRepository.GetAllCustomers();
            return Ok(a);
        }

        /// <summary>
        /// Read config section from config and map to model
        /// </summary>
        /// <returns></returns>
        [HttpGet("globalconfigs")]
        public GlobalConfig GetGlobalConfigs()
        {
            var globalSettings = _configuration.GetSection("GlobalSettings").Get<GlobalConfig>();
            return globalSettings;
        }
 
    }

}
