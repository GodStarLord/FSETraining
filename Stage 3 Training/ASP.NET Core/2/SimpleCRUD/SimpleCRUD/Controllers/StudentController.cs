using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCRUD.Models;

namespace SimpleCRUD.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext _context;

        public StudentController(StudentContext context)
        {
            
            _context = context;
            _context.Database.EnsureCreated(); //This makes sure that the database gets created
            //School school = new School();
            //school.Name = "APK School";
            //_context.Schools.Add(school);
            //_context.SaveChanges();
            //Student student = new Student();
            //student.Name = "Kumar";
            //student.Age = 16;
            //student.Address = "Banglore";

            //_context.Students.Add(student);
            //_context.SaveChanges();

        }

        public IActionResult Index()
        {
            var studentList = _context.Students.Include(x => x.School).ToList();
            return View(studentList);
        }

        public IActionResult Create()
        {
            var schoolList = _context.Schools.ToList();
            schoolList.Insert(0, new School { Id = 0, Name = "Please Select School"});

            ViewBag.SchoolList = schoolList;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                if (student.Id == 0)
                {
                    _context.Students.Add(student);
                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
            var result = _context.Students.Find(id);

            if (result != null)
            {
                _context.Students.Remove(result);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}