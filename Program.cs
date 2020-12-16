using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int summa = 0;
            string rivi;
            
            System.IO.StreamReader file = new System.IO.StreamReader("test.txt");

            while ((rivi = file.ReadLine()) != null)
            {
                System.Console.WriteLine(rivi);
                summa += int.Parse(rivi);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.WriteLine("Summa on: {0}.", summa);
        }
    }
}
