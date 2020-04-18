using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarStore.Domain.Abstract;
using CarStore.Domain.Entities;

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

        public ViewResult Edit(int carId)
        {
            Car car = repository.Cars
                .FirstOrDefault(g => g.CarId == carId);
            return View(car);
        }
    }
}
