using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace basicApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Beginning of Even/Odd number program
            int num, rem;
            Console.Write("A simple program to check if a number is an even integer or an odd integer: \n");
            Console.WriteLine("\n\n");

            Console.Write("Input an integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            rem = num % 2;
            if (rem == 0)
                Console.WriteLine("{0} is an even integer.\n", num);
            else
                Console.WriteLine("{0} is an odd integer.\n", num);

            //Calling the MoonEarth method in this scope
            MoonEarth();
            //End of Even/Odd number program

            Console.WriteLine("------------------------------------------");
            //Unicode character of 72
            char one_char = '\u0048';
            Console.WriteLine(one_char);

            
            bool isMale = true;
            Console.WriteLine(isMale);

            Console.WriteLine("------------------------------");

            //A company's data of employees
            string firstName;
            string lastName;
            byte age;
            char gender;
            uint uniqueIDnumber;

            firstName = "Emmanuel";
            lastName = "Alao";
            age = 65;
            gender = 'm';
            uniqueIDnumber = 27546672;

            Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}", firstName, lastName, age, gender, uniqueIDnumber);

           




            //Array of Numbers
            int[] someValues = new int[20];

            for (int i = 0; i < someValues.Length; i++)
            {
                someValues[1] = i * 5;
                Console.WriteLine(someValues[i]);
            }


            Console.WriteLine("Please enter a four digit number: ");

            string number;
            number = Console.ReadLine();
            char[] array = number.ToCharArray();
            int sum;
            int first = int.Parse(number[0].ToString());
            int second = int.Parse(number[1].ToString());
            int third = int.Parse(number[2].ToString());
            int fourth = int.Parse(number[3].ToString());

            sum = first + second + third + fourth;

            Console.WriteLine("The sum of the digits is {0}", sum);
            Console.WriteLine("Reversed order: {3},{2},{1},{0}", fourth, third, second, first);
            Console.WriteLine("Last digit upfront: {3} {0} {1} {2}", first, second, third, fourth);
            Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", first, second, third, fourth);



        }

        //Beginning of MoonEarth program
        static void MoonEarth()
        {
            float gravity_of_Earth = 9.8f;
            float gravity_of_Moon = 1.666f;

            try
            {
                Console.Write("Enter the man's weight: ");
                double weight_of_the_man = Convert.ToDouble(Console.ReadLine());

                double calc_weight = weight_of_the_man * gravity_of_Earth;
                Console.WriteLine("The weight of the man is " + calc_weight + "m");
            }
            catch (Exception)
            {

                Console.WriteLine("Works fine though! :)");
            }

            
        }
        //End of MoonEarth program
    }
}
