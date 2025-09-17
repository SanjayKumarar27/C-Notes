using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using my_http.Models;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace my_http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAsyncController : ControllerBase
    {
        GoodDbContext _context;
        public StudentAsyncController (GoodDbContext context)
        {
            _context=context;
        }
        // GET: api/<StudentAsyncController>
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            var s=await  _context.Students.ToListAsync();
            return s;
        }

        // GET api/<StudentAsyncController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
           
            Student ?student =await  _context.Students.FindAsync(id);
            if(student == null)
            {
                return Conflict("Student is Not present");
            }
            return student;

        }

        // POST api/<StudentAsyncController>
        [HttpPost]
        public async Task<ActionResult<Student>> Post([FromBody] Student s)
        {
            var existing = await _context.Students.FindAsync(s.Sid);
            if (existing != null)
            {
                return Conflict($"Student with ID {s.Sid} already exists.");
            }

            _context.Students.Add(s);
            _context.SaveChanges();

            return Created("", await _context.Students.ToListAsync());
        }

        [HttpPut]
        public ActionResult Put()
        {
            return Conflict("Not Id pased");
        }


        // PUT api/<StudentAsyncController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> Put(int ?id, [FromBody] Student value)
        {
            if (id == null)
            {
                return Conflict("Id is not given");
            }
            Student ?s =await  _context.Students.FindAsync(id);
            if (s == null)
            {
                return Conflict("Item is Not present");
            }
            s.Sname=value.Sname;
            s.Marks=value.Marks;
            await _context.SaveChangesAsync();
            return Created("",await _context.Students.ToListAsync());

        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Conflict("Id not Given");
        }

        // DELETE api/<StudentAsyncController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> Delete(int id)
        {
           
            Student ?s = await _context.Students.FindAsync(id);
            if (s == null)
            {
                return Conflict("Item is Not present");
            }
            _context.Students.Remove(s);
            await _context.SaveChangesAsync();
            return Created("", await _context.Students.ToListAsync());
        }
    }
}
