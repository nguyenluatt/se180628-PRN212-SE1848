using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Customer
    {
        //POCO
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Addess { get; set; }
        public string phone { get; set; }
        public void PrintInfor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(&"customer Id={Id}");
            Console.WriteLine($"customer Name={Name}");
            Console.WriteLine(&"customer Id={Id}");
            Console.WriteLine($"customer Name={Name}");

            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;

        }
           
    }
}
