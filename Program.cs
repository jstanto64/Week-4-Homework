using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Homework
{
    class Program
    {
        static void Main(string[] args)
        {


            //This is loop to print all whole number
            Console.WriteLine(" Please enter a number.");

            int number = Int32.Parse(Console.ReadLine());

            int start = 1;

            while (start <= number)
            {
                Console.WriteLine($"Your value is: {start}");
                start++;
            }
            Console.ReadLine();


            //This is a loop to print whole numbers in reverse
            Console.WriteLine("Please enter a number.");

            int start2 = 1;

            int enter = Int32.Parse(Console.ReadLine());
            while (enter >= start2)
            {
                Console.WriteLine($"Your value is: {enter}");
                enter--;
            }
            Console.ReadLine();


            //This is a loop to print alphabet from a-z
            char alphabet = 'a';
            while (alphabet <= 'z')
            {
                Console.WriteLine("{0}", alphabet);
                alphabet++;
            }
            Console.ReadLine();


            //This is a loop to print even numbers to 100
            int start3 = 0;

            int finish = 100;
            while (start3 <= finish)
            {
                Console.WriteLine(start3);
                start3 = start3 + 2;
            }
            Console.ReadLine();


            //This is a loop to print odd numbers to 100
            int start4 = 1;

            int finish2 = 99;
            while (start4 <= finish2)
            {
                Console.WriteLine(start4);
                start4 = start4 + 2;
            }
            Console.ReadLine();


            //This is a loop to print sum of  all whole numbers between 1-n
            Console.WriteLine("Please enter a number.");

            int number1 = Convert.ToInt32(Console.ReadLine());

            int number2 = 1;

            int sum = (number1 + number2);
            while (number1 <= number2)
            {
                sum += number1;
                number1++;

                Console.WriteLine($"{sum}");
            }
            Console.ReadLine();


            //This is a loop to print the multiplication table to n
            Console.WriteLine("Please enter a number.");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine("{0} X {1} = {2} \n", n, num, (n * num));
                num++;
            }
            Console.ReadLine();

        }
    }
}
