using System;
using FirstProject.People;
using FirstProject.Calc;

namespace FirstProject
{

  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");
            string name = "sai";
            Console.WriteLine(name);
            name = name.ToUpper();


            Person person = new Person();
            person.Name = "John";
            person.Age = 23;
            person.HasPet = true;

            person.Greeting();

            int result = calculator.Add(5, 10);
            Console.WriteLine(result);


            //array
            string name01 = "Daniel";
            string name02 = "John";
            string name03 = "Jane";
            string name04 = "Tobi";


            string[] names = new string[4];
            names[0] = "Daniel";
            names[1] = "John";
            names[2] = "Jane";
            names[3] = "Tobi";

            // if elif else

            int num1 = 1;
            if (num1 == 1)
            {
                Console.WriteLine("The answer is 1!");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Answer is 2!");
            }
            else
            {
                Console.WriteLine("There was no answer");
            }
            //parse
            string num = Console.ReadLine();
            int num2 = Int32.Parse(num);


            //for loop
            for (int i  = 0; i < 10; i++)
            {
                Console.WriteLine("loop " + i);
            }
            //foreach
            foreach (string x in names)
            {
                Console.WriteLine(x);
            }
            //while
            int num05 = 0;
            while (num05 < 10)
            {
                Console.WriteLine("loop " + num05);
                num05++;
            }
            //Dowhile
            int num06 = 0;
            do
            {
                Console.WriteLine("loop " + num06);
                num06++;
            } while (num06 < 10);


            //multidimensional arrays
            var nameslist = new string[4, 2] //rectangle
            {
                {"Daniel", "28y" },
                {"John", "34y" },
                {"Jane", "23y" },
                {"Tobi", "25y" }
            };
            Console.WriteLine(nameslist[1,0]);

            var nameslist2 = new string[2, 2, 3]
            {
               {
                   {"Rick", "28y", "eye color is green" },
                   {"Danny", "33y", "eye color is brown" }
               },
               {
                   {"Jane", "23y", "eye color is blue" },
                   {"Mary", "22y", "eye color is grey" }
               },
            };
            Console.WriteLine(nameslist2[1, 0, 1]);
            //Jagged array
            var nameslist3 = new int[4][];
            nameslist3[0] = new int[2];
            nameslist3[1] = new int[3];
            nameslist3[2] = new int[1];
            nameslist3[3] = new int[3];

            nameslist3[0][0] = 5;
            nameslist3[0][1] = 3;

            Console.WriteLine(nameslist3[0][1]);
        }

    }
    class Sai
    {
        
    }
}