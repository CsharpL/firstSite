using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{

    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{
                        name ="Tesla Model S",
                        shortDesc = "быстрый автомобиль",
                        longDesc = "Красивый, Быстрый , очень тихий авто от Tesla",
                        img = "/img/TESLA.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()},
                    new Car{
                        name ="Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобыный авто для городской жизни",
                        img = "/img/FIESTA.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car{
                        name ="BMV M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Любичмик молодежи",
                        img = "/img/BMV.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car{
                        name ="Mercedes C class",
                        shortDesc = "Уютный и большой ",
                        longDesc = "Лучший для жизни в гооде",
                        img = "/img/MERS.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car{
                        name ="Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобыный авто для городской жизни",
                        img = "/img/NISSAN.jpeg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()},
                };
            }

        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
