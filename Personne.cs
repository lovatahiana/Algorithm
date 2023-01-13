using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem1
{
    public class Personne
     {
        // Enumeration
        public enum Cities
        {
            Safi,           // Default value = 0
            Marrakech,      // Default value = 1
            Rabat,          // Default value = 2
            Tanger,         // Default value = 3
            CasaBlanca,     // Default value = 4
        }
        // Fields 
        private string _firstName;
        private string _lastName;
        public int Age;
        public string Mobile;
        public Cities Origin;
        public static int Counter = 0;
        public static bool Check = false;

        // Constructors
        public Person()
        {
            Console.WriteLine($"Constructing the Person class .");
            if (!Check)
            {
                StartProgram();
            }
        }
        public Person(string lastName, int age, string mobile, Cities origin, string firstName = "Youssef") : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Mobile = mobile;
            Origin = origin;
            if (!Check)
            {
                StartProgram();
            }
        }
        public Person(Person p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            Age = p.Age;
            Mobile = p.Mobile;
            Origin = p.Origin;
        }

        // Properties 
        public string FirstName
        {
            init
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }
        public static void ChangeAge(ref int oldAge)
        {
            Console.Write($"Please enter your new age : ");
            int newAge;
            if (int.TryParse(Console.ReadLine(), out newAge))
            {
                oldAge = newAge;
            }
            else
            {
                throw new Exception($"Conversion from string to int failed !");
            }
        }
        public void KnowOrigin()
        {
            switch (Origin)
            {
                case Cities.Safi:
                    Console.WriteLine($"This person is originally from {Cities.Safi}");
                    break;
                case Cities.Marrakech:
                    Console.WriteLine($"This person is originally from {Cities.Marrakech}");
                    break;
                case Cities.Rabat:
                    Console.WriteLine($"This person is originally from {Cities.Rabat}");
                    break;
                case Cities.Tanger:
                    Console.WriteLine($"This person is originally from {Cities.Tanger}");
                    break;
                case Cities.CasaBlanca:
                    Console.WriteLine($"This person is originally from {Cities.CasaBlanca}");
                    break;
                default:
                    Console.WriteLine($"Invalid Data !");
                    break;
            }
        }
        public void StartProgram()
        {
            if ((this != null) && (Counter < 1))
            {
                Console.WriteLine($"The program starts ...");
                Counter = 1;
                Check = true;
            }
        }
    }

     static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"First Name : {person.FirstName}");
            Console.WriteLine($"Last Name : {person.LastName}");
            Console.WriteLine($"Age : {person.Age}");
            Console.WriteLine($"Mobile : {person.Mobile}");
            Console.WriteLine($"Origin : {person.Origin}");

            Console.WriteLine("#################################");

            Person person1 = new Person("Baba", 25, "648578564", Person.Cities.Rabat);
            Console.WriteLine($"First Name : {person1.FirstName}");
            Console.WriteLine($"Last Name : {person1.LastName}");
            Console.WriteLine($"Age : {person1.Age}");
            Console.WriteLine($"Mobile : {person1.Mobile}");
            Console.WriteLine($"Origin : {person1.Origin}");

            Console.WriteLine("#################################");

            Person person2 = new Person("Baba", 29, "648488561", Person.Cities.CasaBlanca, "Hassna");
            Console.WriteLine($"First Name : {person2.FirstName}");
            Console.WriteLine($"Last Name : {person2.LastName}");
            Console.WriteLine($"Age : {person2.Age}");
            Console.WriteLine($"Mobile : {person2.Mobile}");
            Console.WriteLine($"Origin : {person2.Origin}");

            Console.WriteLine("#################################");

            Person person3 = new Person(person2);
            Console.WriteLine($"First Name : {person3.FirstName}");
            Console.WriteLine($"Last Name : {person3.LastName}");
            Console.WriteLine($"Age : {person3.Age}");
            Console.WriteLine($"Mobile : {person3.Mobile}");
            Console.WriteLine($"Origin : {person3.Origin}");

            Person.ChangeAge(ref person3.Age);
            Console.WriteLine($"The new age of person = {person3.Age}");
            person3.KnowOrigin();

        }
}