using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zooshop ZS = new Zooshop();
            Console.WriteLine("Заполните информацию о животном:");
            Console.WriteLine("Животное - "); ZS.Animal = Console.ReadLine();
            Console.WriteLine("Пол (м/ж) - "); ZS.Sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Имя - "); ZS.Name = Console.ReadLine();
            Console.WriteLine("Цена - "); ZS.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во - "); ZS.Quant = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Животное - " + ZS.Animal);
            Console.WriteLine("Пол - " + ZS.Sex);
            Console.WriteLine("Имя - " + ZS.Name);
            Console.WriteLine("Цена - " + ZS.Price);
            Console.WriteLine("Кол-во - " + ZS.Quant);

            Console.ReadKey();
        }
    }

    class Zooshop
    {
        public string Animal, Name;
        public char Sex;
        public int Price, Quant;
    }
}
