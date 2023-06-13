// See https://aka.ms/new-console-template for more information
using KunavinAV_01_06;
static Product ReadProductData ()
{
    Console.WriteLine("===Товар на складе===");
    Console.WriteLine("Введите название товара: ");
    string name = Console.ReadLine();
    decimal price;
    int count;

    Console.WriteLine("Введите цену товара: ");
    while (!decimal.TryParse(Console.ReadLine(), out price))
        Console.WriteLine("Ошибка ввода цены товара! Введите корректную цену: ");
    Console.WriteLine("Введите кол-во товара: ");
    while (!int.TryParse(Console.ReadLine(), out count))
        Console.WriteLine("Ошибка ввода кол-ва товара! Введите корректнное кол-во: ");

    return new Product(name, price, count);
}
static ProductChild ReadProductChildData ()
{
    Console.WriteLine("===Товар (класс наследник)===");
    Console.WriteLine("Введите название товара: ");
    string name = Console.ReadLine();
    decimal price;
    int count, year;

    Console.WriteLine("Введите цену товара: ");
    while (!decimal.TryParse(Console.ReadLine(), out price))
        Console.WriteLine("Ошибка ввода цены товара! Введите корректную цену: ");
    Console.WriteLine("Введите кол-во товара: ");
    while (!int.TryParse(Console.ReadLine(), out count))
        Console.WriteLine("Ошибка ввода кол-ва товара! Введите корректнное кол-во: ");
    Console.WriteLine("Введите год выпуска товара: ");
    while (!int.TryParse(Console.ReadLine(), out year))
        Console.WriteLine("Ошибка ввода года выпуска товара! Введите корректный год: ");

    return new ProductChild(name, price, count, year);
}

var product = ReadProductData();
var productChild = ReadProductChildData();

Console.WriteLine(product.Info());
Console.WriteLine(productChild.Info());
