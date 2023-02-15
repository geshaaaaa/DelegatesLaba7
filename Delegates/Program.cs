using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
namespace delegati
{
    
    delegate int Operation(int x, int y);
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Додавання: 2 + 9");

            Operation sum = (int x, int y) => x + y;
            int sumresult = sum(9, 2);
            Console.WriteLine(sumresult);
            Console.WriteLine("Віднімання: -10 - (-10)");
            Operation substract = (int x, int y) => x - y;
            int substractresult = substract(-10, -10);
            Console.WriteLine(substractresult);
            Console.WriteLine("Множення: 4 * 5");
            Operation multiply = (x, y) => x * y;
            int multiplyResult = multiply(4, 5);
            Console.WriteLine(multiplyResult);
            Console.WriteLine("Ділення: 10 / 0");
            Operation divide = (x, y) =>
            {
                if (y == 0)
                    throw new DivideByZeroException("На нуль ділити не можна!");
                else return x / y;

            };
            int divideresult = divide(10, 0);
            Console.WriteLine(divideresult);
        }
    }
}
