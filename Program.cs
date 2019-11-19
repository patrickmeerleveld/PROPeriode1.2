using System;

namespace PROPeriode1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 39;

            bool smart = true;

            char firstLetter = 'p';

            string occupation = "Student";

            float salary =3124777.99f;

            float balance = salary * (age - 12);

            Console.WriteLine("Ik heb "+ balance +" euro op mijn rekening staan :)");

            if(salary > 1000000f) {
                salary = 100000f;
                Console.WriteLine("Balkenende zegt jammer joh!");
                // "+salary+" is een pending
                Console.WriteLine("Ik heb toch maar "+salary+" euro op mijn rekening staan");
            }
            else if(salary > 50000) {
                Console.WriteLine("Gelukkig verdien ik lekker");
            }
            else if(salary > 30000) {
                Console.WriteLine("Ik verdien matig");
            }
            else {
                Console.WriteLine("Ik verdien niet genoeg");
            }

            switch(occupation) {
                case "Teacher":
                Console.WriteLine("Hallo Teacher!");
                break;
                case "Student":
                Console.WriteLine("Hallo Student");
                break;
                case "Concierge":
                Console.WriteLine("Hallo Concierge");
                break;
            }

            int[] ages = new int [9];
            ages[0] = 7;
            ages[1] = 10;
            ages[2] = 8;

            int[] whatever = {4,5,6,7,8,9,0};

            string[] enemies = {"Snake", "Mario", "Luigi"};

            Console.WriteLine(enemies[1]);

            for(int i=0; i < whatever.Length; i++) {
                Console.WriteLine(whatever[i]);
            }
        }
    }
}
