using EfCore.CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EFCore.BulkExtensions;

namespace EfCore.CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompanyContext _companyContext;
        

        public HomeController(ILogger<HomeController> logger, CompanyContext companyContext)
        {
            _logger = logger;
            _companyContext = companyContext;
        }

        public IActionResult Index()
        {
            // var employees = _companyContext.Employees.Where(x=>x.Id>1);
            var employees = _companyContext.Employees.FromSqlRaw("select * from employees").ToList();

            return View(employees);
        }
        [HttpPost]
        public IActionResult Index(string name)
        {
            // var employees = _companyContext.Employees.Where(x=>x.Id>1);
            var employees = _companyContext.Employees.FromSqlRaw("select * from employees where name='" + name + "'").ToList();

            return View(employees);
        }

        [HttpGet]
        public IActionResult Privacy()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Privacy(int choice, int noOfRecords)
        {

            switch (choice)
            {

                case 1:
                    ViewBag.time= InsertwithEachCommit(noOfRecords);
                    break;

                case 2:
                    ViewBag.time = InsertwithOneCommit(noOfRecords);
                    break;

                case 3:
                    ViewBag.time = InsertwithAddRange(noOfRecords);
                    break;
                    

                default:
                    break;
            }

          
           
            return View();
        }



        private TimeSpan InsertwithEachCommit(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            for (int i = 1; i <= n; i++)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Name = "Car-" + i;
                vehicle.CreatedOn = DateTime.Now;
                vehicle.Model = "2022";
                _companyContext.Vehicle.Add(vehicle);
                _companyContext.SaveChanges();
            }
            stopWatch.Stop();
            TimeSpan totalTime = stopWatch.Elapsed;
            return totalTime;
        }

        private TimeSpan InsertwithOneCommit(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; i <= n; i++)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Name = "Car-" + i;
                vehicle.CreatedOn = DateTime.Now;
                vehicle.Model = "2022";
                _companyContext.Vehicle.Add(vehicle);
                
            }
            _companyContext.SaveChanges();
            TimeSpan totalTime = stopWatch.Elapsed;
            return totalTime;
        }

        private TimeSpan InsertwithAddRange(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            List<Vehicle> li = new List<Vehicle>();
  
            for (int i = 1; i <= n; i++)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Name = "Car-" + i;
                vehicle.CreatedOn = DateTime.Now;
                vehicle.Model = "2022";
                li.Add(vehicle);

            }
            _companyContext.AddRange(li);
            _companyContext.SaveChanges();
            TimeSpan totalTime = stopWatch.Elapsed;
            return totalTime;
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
