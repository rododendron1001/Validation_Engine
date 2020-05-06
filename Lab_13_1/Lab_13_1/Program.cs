using System;

namespace Lab_13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Doar test, nefinalizat 

            PersonListProcessor p = new PersonListProcessor("John", "Doe", "2660922052131", 19);



            if (p.Ver_String_Is_Empty() && p.Ver_Numbers_In_String() && p.Ver_Number(18, 99))
            {

                p.Print_Messages();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Statement not OK ");
                Console.WriteLine();

            }

        }
    }
}
