using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorN6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int howMachImageWeHave = 52;
            int imageOnRow = 3;
            int excessImage = howMachImageWeHave % imageOnRow;
            int howMuchRowsFulli = ((howMachImageWeHave - excessImage) / imageOnRow);
            Console.WriteLine("Количество рядов - " + howMuchRowsFulli);
            Console.WriteLine("Осталось картинок - " + (excessImage));
            Console.ReadLine();
        }
    }
}
