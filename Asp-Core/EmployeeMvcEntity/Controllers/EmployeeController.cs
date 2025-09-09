using EmployeeMvcEntity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace EmployeeMvcEntity.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeedbContext ?entity;

        public EmployeeController(EmployeedbContext entity)
        {
            this.entity = entity;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var employeees= await entity.Employees.ToListAsync();
           
            return View(employeees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await entity.AddAsync(employee);
               await entity.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        public async Task<IActionResult> Details(int ?id)
        {
            Employee ?emp =await entity.Employees.FirstOrDefaultAsync(e => e.Eid == id);
            if (id == null)
            {
                return NotFound();
            }
            if(emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        public IActionResult Edit(int id)
        {
            Employee emp=entity.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee emp)
        { 

            if (ModelState.IsValid)
            {
                entity.Update(emp);
                await entity.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }


            return View();
        }


        public async Task<IActionResult> Delete(int id)
        {
            Employee emp = await entity.Employees.FindAsync(id);

            return View(emp);

        }

        [HttpPost,ActionName("Delete")]
        
        public async Task<IActionResult> Delete_Confirmed(int id)
        {

            Employee emp =await entity.Employees.FirstOrDefaultAsync(e => e.Eid ==id);

            entity.Employees.Remove(emp);
            await entity.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

    }
}
