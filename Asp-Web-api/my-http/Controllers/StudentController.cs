using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using my_http.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace my_http.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase

    {
        GoodDbContext _context;
        public StudentController(GoodDbContext context)
        {
            _context=context;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            if (id == null)
            {
                return NotFound("Id is not passed");
            }
            Student s = _context.Students.Find(id);
            if (s == null)
            {
                return NotFound();
            }
            return s;
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student s)
        {
           
            if (!ModelState.IsValid)
            {

            return BadRequest("Body is Not proper");
            }
            Student s2 = _context.Students.Find(s.Sid);
            if (s2 != null)
            {
                return Conflict("Id is alredy present");
            }
            _context.Students.Add(s);
            _context.SaveChanges();
            return Created("", _context.Students.ToList());

            
           
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult<Student> Put(int id, [FromBody] Student stu)
        {
            if (id == null)
            {
                return NotFound("Id is not passed");
            }
            Student s= _context.Students.Find(id);
            if(s == null)
            {
                return NotFound("Inavlid Id ");
            }
            s.Sname = stu.Sname;
            s.Marks=stu.Marks;
           
            _context.SaveChanges();
            return Created("",_context.Students.ToList());

        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult<Student> Delete(int id)
        {
            Student s=_context.Students.Find(id);

            if(s== null)
            {
                return NotFound("Invalid Id");
            }
            _context.Students.Remove(s);
            return Created("", _context.Students.ToList());

        }
    }
}
