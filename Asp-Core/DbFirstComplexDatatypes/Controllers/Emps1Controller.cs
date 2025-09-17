using DbFirstComplexDatatypes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbFirstComplexDatatypes.Controllers
{
    public class Emps1Controller : Controller
    {
        HrContext dbcontext;
        public Emps1Controller(HrContext dbcontext)//DI
        {
            this.dbcontext = dbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var hrcontext = await dbcontext.Emps
                                                 .Include(e => e.DidNavigation)
                                                 .Include(e => e.MidNavigation)
                                                 .ToListAsync();

            return View(hrcontext);

        }


         
        //   public async Task<IActionResult> EmpDpt()
        //  {
        //    var dtoList = await dbcontext.Emps
        //        .Include(e => e.DidNavigation)
        //        .Select(e => new DtoClass
        //        {
        //            EmployeeName = e.FirstName + " " + e.LastName,
        //            DepartmentName = e.DidNavigation.Dname
        //        })
        //        .ToListAsync();

        //    return View(dtoList);
        //}
           public async Task<IActionResult> EmpDpt()
          {
            var dtoList = await (
                                from e in dbcontext.Emps                              
                                select new DtoClass
                                {
                                    EmployeeId= e.Eid,
                                    EmployeeName = e.FirstName + " " + e.LastName,
                                    DepartmentName = e.DidNavigation.Dname
                                }
                            ).ToListAsync();

            return View(dtoList);
        }
           public async Task<IActionResult> EmpMgr()
          {
            var dtoList = await (
                                from e in dbcontext.Emps                              
                                select new EmpMgrDtoClass
                                {
                                    EmployeeId= e.Eid,
                                    EmployeeName = e.FirstName + " " + e.LastName,
                                    ManagerName = e.MidNavigation.FirstName + " " + e.MidNavigation.LastName, 
                                }
                            ).ToListAsync();

            return View(dtoList);
        }

    }
}
