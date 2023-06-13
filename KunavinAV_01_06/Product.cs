using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KunavinAV_01_06
{
    public class Product
    {
        //Название продукта
        public string Name { get; set; }
        //Цена продукта
        public decimal Price { get; set; }
        //Кол-во продукта
        public int Count { get; set; }

        //Конструктор класса Продукт
        public Product (string name, decimal price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        //Метод определения качества товара (базовый класс)
        public virtual decimal Quality() => Count != 0 ? Price / Count : -1;

        //Вывод информации об объекте класса Товар
        public virtual string Info() => $"===Продукт===\nНазвание товара: {Name}\nЦена: {Price}Р.\nКол-во: {Count}\nКАЧЕСТВО: {Quality()}";
    }
}
