using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarStore.Domain.Abstract;
using CarStore.Domain.Entities;

namespace CarStore.WebUI.Controllers
{
    public class CarController : Controller
    {
        private ICarRepository repository;
        public CarController(ICarRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.Cars);
        }
    }
}