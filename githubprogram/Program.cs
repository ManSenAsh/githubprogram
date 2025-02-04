using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ii = 0;
            string ram = "nada";
            Console.WriteLine("ponga su nombre");
            ram = Console.ReadLine();
            Console.WriteLine("ponga cuantas veces se va a repetir");
            ii = int.Parse(Console.ReadLine());

            for (int i = 0; i < ii; i++)
            {
                Console.WriteLine(ram);
            }
            Console.ReadLine();
        }
    }
}
