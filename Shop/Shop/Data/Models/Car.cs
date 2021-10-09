using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { get; set; } // для связи с бд по id 
        public string name { get; set; } // имя товара
        public string shortDesc { get; set; } //короткое описание
        public string longDesc { get; set; } //длинное поисание товара
        public string img { get; set; } //путь на фотку товара url
        public ushort price { get; set; } //цена товара , всегда положительная
        public bool isFavourite { get; set; } // товар  который будет отображатся на главной странице
        public bool available { get; set; } // есть ли товар
        public int categoryID { get; set; } // какая-то категория по id
        public virtual Category Category { get;set;}
    }
}
