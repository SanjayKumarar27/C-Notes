using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class TestController : Controller
    {
        /*
        public string Index(string id)
        {
            return $"Hai {id} I am Test Controller and Index Actions";
        }
        public string Demo()
        {
            return "Demo";
        }
        */
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()//Controller send data directly to veiw
        {
            //create a arrray of string and send the data
            //string[] str = new string[] { "Sanjay", "Pragna", "Kaushik" };
           List<String> student=new List<String>()
           {
               "Sanjay",
               "Pragna",
               "Kaushik",
               "Sandeep"
           };
            

            //ViewData["com"] = "KPMG";

            //ViewBag.Day = "Teacher Day";
            ViewBag.Student = student;
            return View();
        }
        public IActionResult Details()//sends data to modal through veiw
        {
            emp Emp = new emp() { Id = 101, Name = "Depak", Sal = 45000 };
         
            return View(Emp);
        }
        public IActionResult EmpList()
        {
            
            List<emp> e1 = new List<emp>()
{
    new emp() { Id = 1, Name = "Aaa", Sal = 100000 },
    new emp() { Id = 2, Name = "Bbb", Sal = 80000 },
    new emp() { Id = 3, Name = "Ccc", Sal = 150000 }
};


            return View(e1);
        }
        public IActionResult EmpList1()
        {

            List<emp> e1 = new List<emp>()
{
    new emp() { Id = 1, Name = "Aaa", Sal = 100000 },
    new emp() { Id = 2, Name = "Bbb", Sal = 80000 },
    new emp() { Id = 3, Name = "Ccc", Sal = 150000 }
};


            return View(e1);
        }
    }
}
