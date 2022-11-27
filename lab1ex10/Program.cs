using System;

namespace lab1ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Scrieti un program care sa va afisa suma cifrelor 
            ununi numar intreg citit de la tastatura.
            */

            int number;
          
            Console.WriteLine("Introduceti numarul: ");
            number = int.Parse(Console.ReadLine());
           
            int sum=0;
            while(number>0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }
            Console.WriteLine("Suma este: " + sum);
        }
    }
}
