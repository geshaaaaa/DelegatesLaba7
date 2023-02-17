using System;
using System.Collections.Generic;
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
            sum(9, 2);
            Operation substract = (x, y) => Console.WriteLine($"{x} - {y} = {x - y}");
            substract(10, 3);
            Operation multiply = (x, y) => Console.WriteLine($"{x} * {y} = {x * y}");
            multiply(11, 4);
            Operation divide = Divide;
            divide(10, 0);  
            divide(9, 3);
            void Divide(int x, int y)
            {
                if (y == 0)
                {
                    Console.WriteLine("На нуль ділити не можна!");
                }
                else
                {
                    Console.WriteLine($"{x} / {y} = {x / y}");
                }
            }
                
        }
    }
}
