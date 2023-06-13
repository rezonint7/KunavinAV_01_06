using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KunavinAV_01_06
{
    public class ProductChild : Product
    {
        //Год выпуска товара
        public int YearP { get; set; }

        //Конструктор класса Продукт наследник
        public ProductChild (string name, decimal price, int count, int year) : base(name, price, count)
        {
            Name = name;
            Price = price;
            Count = count;
            YearP = year;
        }

        //Метод определения качества товара наследника
        public override decimal Quality() => base.Quality() + (0.5m * (DateTime.Now.Year - YearP));

        //Вывод информации об объекте класса Товар
        public virtual string Info() => $"===Продукт (наследник)===\nНазвание товара: {Name}\nЦена: {Price}Р.\nКол-во: {Count}\nГод выпуска: {YearP}\nКАЧЕСТВО: {Quality()}";

    }
}
