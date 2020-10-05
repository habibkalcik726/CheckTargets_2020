using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CheckTargets_2020.Models;
using CheckTargets_2020.DBModel.Context;
using CheckTargets_2020.DBModel.Repository;
using CheckTargets_2020.DBModel.DBObjects;
using CheckTargets_2020.DBModel.DBObjects.Contracts;

namespace CheckTargets_2020.Controllers
{
    public class HomeController : Controller
    {
      

        //EFRepository<Notifications> NotificationstRepo = new EFRepository<Notifications>();
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private IRepositoryWrapper _repoWrapper;
        public HomeController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public IActionResult Index()
        {

            // NotificationsRepo nr = new NotificationsRepo();
            //.Insert(nt);
            Users user = new Users();
            user.Username = "hbb";
            user.Password = "password";

            _repoWrapper.Users.Insert(user);
            _repoWrapper.Save();
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
