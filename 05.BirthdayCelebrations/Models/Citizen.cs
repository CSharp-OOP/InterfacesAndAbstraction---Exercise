using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Citizen : IIdentifiable, IBirthable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id,string birthdate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }
    }
}
