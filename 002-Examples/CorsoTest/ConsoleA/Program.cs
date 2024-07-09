// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

using ConsoleA.Register;
using System;

// Nota: Questo è un commento su singola riga

/*
    Questo è un commento
    multiriga  
*/

namespace ConsoleA
{

    class Program
    {

        static void Main(string[] args)
        {

            // Scrivo a console un testo

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Step 1");
            Console.WriteLine("Step 2");
            Console.WriteLine("Step 3");

            Test01();
            Test02();
            Test03();

            Test04();


        }

        static void Test01() {
            Console.WriteLine("Range int => [" + int.MinValue + "," + int.MaxValue + "]");


            int a = -5;
            int b = 12;

            int c = a + b;

            Console.WriteLine("Il risultato della somma è " + c);

            checked
            {
                try
                {
                    int x1 = int.MinValue; // - 2147483648;
                    Console.WriteLine("x1 =  " + x1);
                    int x2 = x1 - 100;
                    Console.WriteLine("x2 =  " + x2);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Questo è un intercetto un errore");
                    Console.WriteLine("Errore: " + ex.Message);
                }
            }


            // Intero a 64 bit
            long a0 = 12;

            // Intero a 32 bit
            int a1 = 5;

            uint a2 = 5u; //[0,2^32 -1]

            ulong aa1 = 5l;

            // Intero a 16 bit
            short a2_1 = 0;

            // Intero a 8 bit
            byte a3 = 0;

            sbyte a4 = 0;



            float b1 = 0.5f;

            double b2 = 0.5d;

            double b2a = 0.5;

            decimal b3 = 0.4m;

        }

        static void Test02() {

            int a = 100;

            long b = a;


            long c = 123;
            int d = ((int)c);

            string msg = "Questo è un testo memorizzato in una variabile";

            bool test1 = false;
            bool test2 = true;

        }

        static void Test03() {

            Car obj1 = new Car();

            obj1.brand = "BMW";
            // obj1.CC = 500;
            obj1.doors = 3;
            obj1.model = "c1";

            Car obj2 = obj1;

            Car obj3 = new Car();
            obj3.brand = "Mercedes";
            obj3.doors = 5;
            obj3.model = "Benz";

            obj3.Start();
            obj3.Stop();
            obj3.GetGas();

            obj3.CC = 1500;

            obj3.CC = 200;

            Console.Write("CC obj3 = " + obj3.CC);
            
            int dayInsuranceExpire = obj3.CalcDayInsuranceToEnd();




        }


        static void Test04() {

            Person person1 = new Person();
            person1.FirstName = "Antonio";
            person1.LastName = "Minelli";
            person1.BirthDate = new DateTime(1974, 11, 07);


            Person person2 = new Person("Robin","Brambilla", new DateTime(2000,2,3));

            //person1.PrintData();
            //person2.PrintData();
            PrintPerson(person1);
            PrintPerson(person2);

            Employee employee1 = new Employee("Robin", "Brambilla", new DateTime(2000, 2, 3), "MAT0012");
            PrintPerson(employee1);
            //employee1.PrintData();

        }



        static void PrintPerson(Person person) {
            if (person != null) {
                person.PrintData();
            }
        }



    }
}




