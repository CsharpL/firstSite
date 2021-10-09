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
                        img = "https://moscowteslaclub.ru/cars/tesla-model-s-plaid-2021_27001/?baobab_event_id=kuhzk7ok0&yclid=5917535375422708367&roistat=direct19_search_10726459292_%D0%92%D1%81%D0%B5&roistat_referrer=none&roistat_pos=premium_1&from=yadirectfeed",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()},
                    new Car{
                        name ="Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобыный авто для городской жизни",
                        img = "https://yandex.ru/images/search?from=tabbar&text=ford%20fiesta&pos=0&img_url=https%3A%2F%2Fsun9-60.userapi.com%2Fc636925%2Fv636925054%2F378ea%2Fz2q-psxpSAk.jpg&rpt=simage",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car{
                        name ="BMV M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Любичмик молодежи",
                        img = "https://yandex.ru/images/search?pos=0&from=tabbar&img_url=https%3A%2F%2Fw-dog.ru%2Fwallpapers%2F1%2F0%2F505045271642184%2Fbmw-m3-e92-sinij-bmv.jpg&text=bmv%20m3%20img&rpt=simage",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car{
                        name ="Mercedes C class",
                        shortDesc = "Уютный и большой ",
                        longDesc = "Лучший для жизни в гооде",
                        img = "https://yandex.ru/images/search?pos=0&from=tabbar&img_url=https%3A%2F%2Fs1.1zoom.ru%2Fbig3%2F701%2FMercedes-Benz_White_437294.jpg&text=mers+c+class&rpt=simage",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car{
                        name ="Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобыный авто для городской жизни",
                        img = "https://yandex.ru/images/search?pos=0&from=tabbar&img_url=https%3A%2F%2Fscontent-arn2-1.cdninstagram.com%2Fv%2Ft51.2885-15%2Fe35%2F116048850_2394200154207582_578005645181481567_n.jpg%3F_nc_ht%3Dscontent-arn2-1.cdninstagram.com%26_nc_cat%3D106%26_nc_ohc%3DIA8ZWdEt8AEAX8kHy09%26oh%3D3499c2f3764c0f46a46a32d5347c0945%26oe%3D5F52B125&text=nissan+leaf&rpt=simage",
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
