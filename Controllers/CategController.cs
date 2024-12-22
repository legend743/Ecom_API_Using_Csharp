using Ecomm.Data;
using Ecomm.Modal;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategController : ControllerBase
    {
        private ApllicationDbContext _context;

        public CategController(ApllicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CategController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.Categories

        // GET api/<CategController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id==id);
        }

        // POST api/<CategController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
