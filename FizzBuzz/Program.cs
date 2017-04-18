using System;
using System.IO;

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
        }
    }
}
