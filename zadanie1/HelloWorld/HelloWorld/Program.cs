using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        private static string input;
        private static bool result;

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj Świecie");
            Console.Write("Wpisz 'exit' i naciśnij klawisz ENTER aby zakończyć działanie: \r\n");
            string line;
            while ((line = Console.ReadLine()) != "exit")
            {
                Console.WriteLine(result);
            }
        }
    }
}
