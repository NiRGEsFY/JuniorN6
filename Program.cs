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
            int excess = (howMachImageWeHave % imageOnRow);
            int howMuchRows = ((howMachImageWeHave - excess) / imageOnRow);
            Console.WriteLine("Количество рядов - " + howMuchRows);
            Console.WriteLine("Осталось картинок - " + (excess));
            Console.ReadLine();
        }
    }
}
