using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace my_http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string> { "value1", "value2", "value3", "value4" };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return values;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)

        {
            if (id > values.Count|| id<=0)
            {
                return NotFound("Data Not Found");
            }
            return Ok(values[id-1]);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult<List<string>> Post([FromBody] string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return BadRequest("value not passed");
            }
            values.Add(value);
            //Console.WriteLine(value);
            return values; 
        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult<List<string>> Put(int id, [FromBody] string value)

        {
            if (id > values.Count || id <= 0)
            {
                return NotFound("Invalid Id ");
            }
            values[id-1] = value;
            Console.WriteLine(value);

            return values;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult<List<string>> Delete(int id)
        {
            if (id > values.Count || id <= 0)
            {
                return NotFound("Invalid Id");
            }

            values.Remove(values[id-1]);

            return values;
        }
    }
}
