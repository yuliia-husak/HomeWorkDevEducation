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
        public int pageSize = 4;
        public CarController(ICarRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page=1)
        {
            return View(repository.Cars
                .OrderBy(car => car.CarId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize));
        }
    }
}