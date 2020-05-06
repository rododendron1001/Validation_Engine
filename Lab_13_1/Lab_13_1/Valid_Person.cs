using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_1
{
    class Valid_Person
    {
        public PersonListProcessor[] Lista { get; }

        public Valid_Person(PersonListProcessor[] lista)
        {
            this.Lista = lista ?? new PersonListProcessor[0];
        }


    }
}
