using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Robot : IIdentifiable
    {
        private string name;

        public Robot(string name, string id)
        {
            this.name = name;
            this.Id = id;
        }

        public string Id { get; private set; }
        public string Birthdate { get; set; }
    }
}
