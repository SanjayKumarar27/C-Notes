using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVCEnitity.Models;

namespace WebMVCEnitity.Controllers
{
    public class StudentController : Controller
    {
        EnityDbContext entity;
        public StudentController(EnityDbContext entity)
        {
            this.entity = entity;
        }

        //sync
        //public IActionResult Index()
        //{
        //    var students = entity.Students.ToList();

        //    return View(students);
        //}

        //Async
        public async Task<IActionResult> IndexAsync()
        {
            var students = await entity.Students.ToListAsync();

            return View(students);
        }

        public IActionResult Create()
        {

            return View();
        }
        //[HttpPost]
        //public IActionResult Create(Student student)
        //{
        //    if (ModelState.IsValid)//help to prevent the hacker from doing post methods
        //    {
        //        entity.Students.Add(student); --recommended
        //        entity.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(student);
        //}
        //public IActionResult Create(Student s)
        //{
        //    entity.Add(s);//if one collection else give the collection name as above
        //    entity.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        //Async
        public async Task<IActionResult> Create(Student s)
        {
            if ( ModelState.IsValid)
            { 
                await entity.AddAsync(s);
                await entity.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(s);

        }

        //sync
        //public IActionResult Details(int id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    Student ?student = entity.Students.FirstOrDefault(s => s.Sid == id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(student);
        //}


        //Async
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Student? student =await entity.Students.FirstOrDefaultAsync(s => s.Sid == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        //public IActionResult Edit(int id)
        //{
        //    var student = entity.Students.Find(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(student);
        //}

        //sync
        //public IActionResult Edit(int id)
        //{
        //    Student ?student = entity.Students.Single(s => s.Sid == id);
        //    return View(student);

        //}

        //Async
        public async Task< IActionResult> Edit(int id)
        {
            Student? student = await entity.Students.FirstOrDefaultAsync(s => s.Sid == id);
            return View(student);

        }

        //Sync
        //[HttpPost]
        //public IActionResult Edit(Student s)
        //{
        //    entity.Update(s);
        //    entity.SaveChanges();
        //    return RedirectToAction("index");
        //}


        //Async
        [HttpPost]

        public async Task<IActionResult> Edit(Student s)
        {
            entity.Update(s);
            await entity.SaveChangesAsync();
            return RedirectToAction("index");
        }


        //sync
        //public IActionResult Delete(int id)
        //{
        //    var student = entity.Students.Find(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(student);
        //}

        //Async
        public async Task<IActionResult> Delete(int id)
        {
            var student = await entity.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        ////dotnet tool install --global dotnet-ef
        //dotnet ef dbcontext scaffold "Name=ConnectionStrings:mycon" Microsoft.EntityFrameworkCore.SqlServer -o Models --force
        //dotnet ef dbcontext scaffold "Name=ConnectionStrings:myconn" Microsoft.EntityFrameworkCore.SqlServer
        //-o Models --force

                //Sync
                //[HttpPost, ActionName("Delete")]
                //public IActionResult DeleteConfirmed(int id)
                //{
                //    var student = entity.Students.Find(id);
                //    if (student != null)
                //    {
                //        entity.Students.Remove(student);
                //        entity.SaveChanges();
                //    }
                //    return RedirectToAction(nameof(Index));
                //}

                //async
                [HttpPost,ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int ?id)
        {
            Student ?st=await entity.Students.FindAsync(id);
            if (st != null)
            {
                entity.Students.Remove(st);
                entity.SaveChangesAsync();
            }
            return RedirectToAction("Index");   
        }



    }
}
