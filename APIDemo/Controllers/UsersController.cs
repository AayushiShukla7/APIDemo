using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemo.Controllers
{
    [Produces(MediaTypeNames.Application.Json,
  MediaTypeNames.Application.Xml)]
    [Consumes(MediaTypeNames.Application.Json,
  MediaTypeNames.Application.Xml)]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        // GET: api/Users
        /// <summary>
        /// Returns a collection of URLs
        /// </summary>
        /// <param name="slugs">list of slugs to retrieve</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     Get /api/slugscollection/(d25tRx, fN5jpz)
        ///
        /// </remarks>
        /// <returns>IEnumerable of slugs</returns>
        /// <response code="200">If all requested items are 
        /// found</response>
        /// <response code="400">If slugs parameter is missing</response>
        /// <response code="404">If number of records found doesn't equal 
        /// number of records requested</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Users/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
