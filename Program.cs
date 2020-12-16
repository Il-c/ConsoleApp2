using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int summa = 0;
            string line;
            Console.WriteLine("Hello World!");
            System.IO.StreamReader file = new System.IO.StreamReader("test.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                summa += int.Parse(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.WriteLine("Summa on: {0}.", summa);
        }
    }
}
