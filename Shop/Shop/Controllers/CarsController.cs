using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _AllCategories;
        public CarsController(IAllCars iAllCars,ICarsCategory iCarsCat) {
            _allCars = iAllCars;
            _AllCategories = iCarsCat;
        }
        public ViewResult List()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
