using EmployeeDirectoryApp.Data;
using EmployeeDirectoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;

namespace EmployeeDirectoryApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _db;

        public EmployeeController(EmployeeDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> EmployeeList = _db.Employees;
            return View(EmployeeList);
        }

        

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid) 
            {
                _db.Employees.Add(emp);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }
        
        //Get
        public IActionResult Update(int? id)
        {
            if ( id == null || id == 0 ) 
            {
                return NotFound();
            }
            
            var empFromDb = _db.Employees.Find(id);
            if (empFromDb == null)
            {
                return NotFound();
            }
            return View(empFromDb);
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(emp);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        //Get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var empFromDb = _db.Employees.Find(id);
            if (empFromDb == null)
            {
                return NotFound();
            }
            return View(empFromDb);
        }

        //Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmp(int? id)
        {
            var emp = _db.Employees.Find(id);
            if(emp == null)
            {
                return NotFound();
            }
 
            _db.Employees.Remove(emp);
            _db.SaveChanges();
            return RedirectToAction("Index");
           
        }
    }
}
