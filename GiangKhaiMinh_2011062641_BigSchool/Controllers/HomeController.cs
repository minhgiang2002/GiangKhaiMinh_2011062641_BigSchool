﻿using GiangKhaiMinh_2011062641_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using GiangKhaiMinh_2011062641_BigSchool.ViewModels;

namespace GiangKhaiMinh_2011062641_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbcontext;
        public HomeController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcomingCourses = _dbcontext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            //return View(upcomingCourses);

            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upcomingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
