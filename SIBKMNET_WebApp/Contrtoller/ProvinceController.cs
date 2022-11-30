using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIBKMNET_WebApp.Context;
using SIBKMNET_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_WebApp.Contrtoller
{
    public class ProvinceController : Controller
    {
        MyContext myContext;

        public ProvinceController(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public IActionResult Index()
        {
            var data = myContext.Provinces.Include(x => x.Region).ToList();
            return View(data);
        }

        public IActionResult Details(int id)
        {
            var data = myContext.Provinces.Include(x => x.Region).FirstOrDefault(x => x.Id.Equals(id));
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Province country)
        {
            if (ModelState.IsValid)
            {
                myContext.Provinces.Add(country);
               var result = myContext.SaveChanges();
                if (result > 0)
                    return RedirectToAction("Index"); 

            }
            return View();
        }
    }
}
