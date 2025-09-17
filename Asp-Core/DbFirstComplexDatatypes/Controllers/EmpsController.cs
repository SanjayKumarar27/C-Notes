using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DbFirstComplexDatatypes.Models;

namespace DbFirstComplexDatatypes.Controllers
{
    public class EmpsController : Controller
    {
        private readonly HrContext _context;

        public EmpsController(HrContext context)
        {
            _context = context;
        }

        // GET: Emps
        public async Task<IActionResult> Index()
        {
            var hrContext = _context.Emps.Include(e => e.DidNavigation).Include(e => e.MidNavigation);
            return View(await hrContext.ToListAsync());
        }

        // GET: Emps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp = await _context.Emps
                .Include(e => e.DidNavigation)
                .Include(e => e.MidNavigation)
                .FirstOrDefaultAsync(m => m.Eid == id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        // GET: Emps/Create
        public IActionResult Create()
        {
            ViewData["Did"] = new SelectList(_context.Depts, "Did", "Did");
            ViewData["Mid"] = new SelectList(_context.Emps, "Eid", "Eid");
            return View();
        }

        // POST: Emps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eid,FirstName,LastName,Doj,Dob,Sal,Comm,Mid,Did,Jobs,Gender")] Emp emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Did"] = new SelectList(_context.Depts, "Did", "Did", emp.Did);
            ViewData["Mid"] = new SelectList(_context.Emps, "Eid", "Eid", emp.Mid);
            return View(emp);
        }

        // GET: Emps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp = await _context.Emps.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            ViewData["Did"] = new SelectList(_context.Depts, "Did", "Did", emp.Did);
            ViewData["Mid"] = new SelectList(_context.Emps, "Eid", "Eid", emp.Mid);
            return View(emp);
        }

        // POST: Emps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Eid,FirstName,LastName,Doj,Dob,Sal,Comm,Mid,Did,Jobs,Gender")] Emp emp)
        {
            if (id != emp.Eid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpExists(emp.Eid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Did"] = new SelectList(_context.Depts, "Did", "Did", emp.Did);
            ViewData["Mid"] = new SelectList(_context.Emps, "Eid", "Eid", emp.Mid);
            return View(emp);
        }

        // GET: Emps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp = await _context.Emps
                .Include(e => e.DidNavigation)
                .Include(e => e.MidNavigation)
                .FirstOrDefaultAsync(m => m.Eid == id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        // POST: Emps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emp = await _context.Emps.FindAsync(id);
            if (emp != null)
            {
                _context.Emps.Remove(emp);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpExists(int id)
        {
            return _context.Emps.Any(e => e.Eid == id);
        }
    }
}
