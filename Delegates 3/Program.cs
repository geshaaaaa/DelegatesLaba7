using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
namespace delegates3
{
    class Program
    {
        delegate float Givesr(int x,int y,int z);
        static void Main()
        {
           
            Givesr givesr = delegate (int x, int y, int z)
            {
                float sr = 0;
                sr += (x + y + z)/3;
                return sr;
            };
            float result = givesr(3,21,6 );
            Console.WriteLine($"Середнє арифметичне:{result}");
        }
    }
}