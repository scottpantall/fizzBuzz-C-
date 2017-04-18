using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEY YOU GUUYYYS!");

            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); //Pauses app until key is pressed
        }
    }
}
