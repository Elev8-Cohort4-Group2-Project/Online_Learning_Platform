﻿using LMS_Clone.Data;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Clone.Controllers {
    public class CourseController : Controller {
        private readonly AppDbContext? _context;

        public CourseController(AppDbContext context) {
            _context = context;
        }


        public IActionResult Index() {
            return View();
        }


        public IActionResult Create() {
            return View();
        }

        public IActionResult Edit() {
            return View();
        }

       public IActionResult Delete() {
            return View();
        }


























    }
}
