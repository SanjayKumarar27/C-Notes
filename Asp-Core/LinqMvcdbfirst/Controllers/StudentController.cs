using LinqMvcdbfirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LinqMvcdbfirst.Controllers
{
    public class StudentController : Controller
    {
        LinqDbContext dbContext;

        public StudentController(LinqDbContext dbContext)//DI
        {
            this.dbContext= dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var res = from s in dbContext.Students
                      select s;

            return View(await res.ToListAsync());
        }
       

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                await  dbContext.AddAsync(student);
                await  dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                return View(student);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await (from s in dbContext.Students
                                 where s.Sid == id
                                 select s).FirstOrDefaultAsync();

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                dbContext.Students.Update(student);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public async Task<IActionResult> Delete(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var res = await (from s in dbContext.Students
                             where s.Sid == id
                             select s).FirstOrDefaultAsync();

            return View(res);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Student ?s =await dbContext.Students.FindAsync(id);
            if (s == null)
            {
                return NotFound();
            }
            dbContext.Students.Remove(s);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult > Details(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var res = await (from s in dbContext.Students
                            where s.Sid == id
                            select s).FirstOrDefaultAsync();

            return View(res);

        }







    }
}
