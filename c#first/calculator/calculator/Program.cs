using System;
using System.Collections.Generic;




namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //set variables 
            Console.WriteLine("Select an operation: +, -, *, /");
            string operation = Console.ReadLine();
            Console.WriteLine("Whats the first number?");
            string num1 = Console.ReadLine();
            Console.WriteLine("Whats the second number?");
            string num2 = Console.ReadLine();

            //conditionals check if number
            int num = 0;
            bool result = int.TryParse(num1, out num);
            bool result2 = int.TryParse(num2, out num);
            if (result == false)
            {
                Console.WriteLine("Make sure you input a number into num1!");
            }
            if (result2 == false)
            {
                Console.WriteLine("Make sure you input a number into num2!");
            }

            //change strings to int
            int num3 = Int32.Parse(num1);
            int num4 = Int32.Parse(num2);



            //conditionals operation
            if (operation == "+")
            {
                int answer = num3 + num4;
            }
            else if (operation == "-")
            {
                int answer = num3 - num4;
            }
            else if (operation == "*")
            {
                int answer = num3 * num4;

            }
            else if (operation == "/")
            {
                int answer = num3 / num4;

            }
            else
            {
                Console.WriteLine("Make sure you entered the operation correctly!");

            }





        }
    }

}