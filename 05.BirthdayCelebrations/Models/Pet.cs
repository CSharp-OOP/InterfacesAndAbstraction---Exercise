using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, string birthday)
        {
            this.name = name;
            this.Birthdate = birthday;
        }


        public string Birthdate { get; private set; }

        public string Id { get;}
    }
}
