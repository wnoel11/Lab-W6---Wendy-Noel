using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_W6___Wendy_Noel
{
    class Program
    {
        static void Main(string[] args)
        {


            //#1 The if single-selection statement and the while repeition statement are similiar because
            //both perform an action based on whether a condition is true. The difference between the two 
            //statements is, the if single-selection statement will only perform the action once and 
            //the while repeititon statement repeats the action until the condition is false.
         
            //#2 

            int speedLimit = 35;
            int speed = 42;

            Console.WriteLine("Enter the Speed Limit");
            speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the vehicle's speed");
            speed = int.Parse(Console.ReadLine());

            if (speed >= speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            Console.ReadLine();

            //#3

            int isTrue = 25;

            Console.WriteLine("Enter a value");
            isTrue = int.Parse(Console.ReadLine());

            Console.WriteLine(isTrue >= 25 ? "It is True!" : "It is False!");

            Console.ReadLine();

            //#4

            Console.WriteLine("Enter the temperature in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;

            if (fahrenheit <= 40)
            {
                Console.WriteLine("The temperature in celsius is {0}. It is cold.", celsius);
            }

            else if (fahrenheit >= 90)
            {
                Console.WriteLine("The temperature in celsius is {0}. It is hot.", celsius);
            }

            else
            {
                Console.WriteLine("The temperature in celsius is {0}", celsius);
            }

            
            Console.ReadLine();

            //#5

            int i = 1;

            while (i < 11)
            {
                Console.WriteLine(i);

                i = i + 1; 
            }

            Console.ReadLine();

            //#6

            int x = 60;

            while (x > 19)
            {
                Console.WriteLine(x);

                x = x - 1;
            }

            Console.ReadLine();

            //#7

            int z = 10;

            while (z < 21)
            {
                Console.WriteLine(z);

                z = z + 1;
            }

         
        }


    }
}
