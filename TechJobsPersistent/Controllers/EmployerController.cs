using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;
using TechJobsPersistent.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
   
    public class EmployerController : Controller
    {
        private JobDbContext context;
        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }



        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }


        public IActionResult Add(AddEmployerViewModel addEmployerViewModel)
        {
            return View(addEmployerViewModel);
        }



        [HttpPost]
        
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer temp = new Employer()
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };
                context.Employers.Add(temp);
                context.SaveChanges();
            }
            
            return View();
        }






        public IActionResult About(int id)
        {
            foreach(var employer in context.Employers)
            {
                if (employer.Id == id)
                {
                    return View(employer);
                }
            }
            return View();
        }
    }
}
