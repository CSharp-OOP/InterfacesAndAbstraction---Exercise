using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string secondName, int codeNumber) 
            : base(id, firstName, secondName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }
    }
}
