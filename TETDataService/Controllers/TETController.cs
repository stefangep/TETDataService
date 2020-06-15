using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TETDataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TETController : ControllerBase
    {

        /////////////https://etservices.thermia.com/configuration?macaddress=0C-1C-57-51-18-4A 
        /// <summary>
        /// // tetdataserver.azurewebsites.net/
        /// </summary>
        /// <param name="macaddress"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("tetdataserver.azurewebsites.net/configuration/{macaddress}")]
        public dynamic getConfiguration(string macaddress)
        {
            //ServicePointManager
            //  .ServerCertificateValidationCallback +=
            //  (sender, cert, chain, sslPolicyErrors) => true;
            try
            {

                return "true";
            }
            catch (Exception e)
            {
                string mess = e.Message;
                return "Fail";
            }
        }


        // GET: api/<TETController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TETController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TETController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TETController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TETController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
