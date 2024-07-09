using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleA.Register
{
    public class Person
    {

        public Person() {
            Console.WriteLine("Costruttore di default");
        }


        public Person(string firstName, string lastName, DateTime birthDate)
        {
            Console.WriteLine("Costruttore custom con i dati");
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public virtual void PrintData() {
            Console.WriteLine("Io Sono una Persona " + FirstName + " " + LastName);

        }


    }

    public class Employee : Person
    {
        public string RegistrationNumber { get; set; }

        public Employee() : base()
        {
        
        }


        public Employee(string firstName, string lastName, DateTime birthDate, string registrationNumber) 
            : base(firstName, lastName, birthDate)
        {           
            RegistrationNumber = registrationNumber;
        }

       
        public override void PrintData()
        {
            Console.WriteLine("Io Sono il dipendente " + FirstName + " " + LastName + " " + RegistrationNumber);

        }
       

    }
}
