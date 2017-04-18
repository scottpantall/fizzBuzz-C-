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
            int fizz;
            int buzz;
            int outputLength;

            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] numbers = line.Split(' ');

                    fizz = Int32.Parse(numbers[0]);
                    buzz = Int32.Parse(numbers[1]);
                    outputLength = Int32.Parse(numbers[2]);

                    for(int i = 1; i <= outputLength; i++)
                    {
                        if ((i % fizz == 0) && (i % buzz == 0))
                            Console.Write("FB ");
                        else if (i % fizz == 0)
                            Console.Write("F ");
                        else if (i % buzz == 0)
                            Console.Write("B ");
                        else
                            Console.Write(i + " ");
                    }
                    Console.Write("\n");  
                }

            //Pauses app until key is pressed
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); 
        }
    }
}
