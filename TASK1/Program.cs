using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
namespace delegati
{
    
    delegate void Operation(int x, int y);
    class Program
    {
        static void Main()
        {

            Operation sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
            Operation substract = (x, y) => Console.WriteLine($"{x} - {y} = {x - y}");
            Operation multiply = (x, y) => Console.WriteLine($"{x} * {y} = {x * y}");
            Operation Divide = (int x, int y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("На нуль ділити не можна!");
                }
                else
                {
                    Console.WriteLine($"{x} / {y} = {x / y}");
                }
            };

            Console.WriteLine("Оберіть числа для операції");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int a;
            Console.WriteLine("Оберіть дію: 1-додавання, 2-віднімання, 3-множення, 4-ділення ");
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: sum(x, y); 
                break;   
                case 2: substract(x, y);
                break;
                case 3: multiply(x, y); 
                break;
                case 4: Divide(x, y); 
                break;


            }
           
            
        }

      
    }
}
