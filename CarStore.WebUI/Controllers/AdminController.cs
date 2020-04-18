using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarStore.Domain.Abstract;

namespace CarStore.WebUI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        ICarRepository repository;

        public AdminController(ICarRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Cars);
        }
    }
}
