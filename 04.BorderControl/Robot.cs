using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
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
    }
}
