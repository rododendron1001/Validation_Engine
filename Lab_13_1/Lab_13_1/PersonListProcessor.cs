using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Verif_Library;

namespace Lab_13_1
{
    class PersonListProcessor : Abstract_Verif_Library.Abstract_Verif_Class
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Cnp { get; set; }
        public int Age { get; set; }

        public PersonListProcessor(string lastName, string firstName, string cnp, int age)
        {
            this.LastName = lastName ?? string.Empty;
            this.FirstName = firstName ?? string.Empty;
            this.Cnp = cnp ?? string.Empty;
            this.Age = age;
        }

        public override bool Ver_String_Is_Empty()
        {
            bool result = !(string.IsNullOrEmpty(LastName) && string.IsNullOrEmpty(FirstName));
            return result;

        }

        public override bool Ver_Numbers_In_String()
        {
            bool result = (long.TryParse(Cnp, out long i) && (i > 0));
            return result;
        }

        public override bool Ver_Number(int min, int max)
        {
            bool result = (Age >= min) && (Age <= max);
            return result;
        }

        public void Print_Messages()
        {

            Console.WriteLine($"Person  :  {FirstName} , {LastName} , {Cnp} , {Age}");
            Console.WriteLine();

        }
    }
}
