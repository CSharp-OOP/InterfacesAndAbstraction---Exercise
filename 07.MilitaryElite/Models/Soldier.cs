using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    public abstract class Soldier : ISoldier
    {
        public Soldier(int id, string firstName, string secondName)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
        }

        public int Id { get; }

        public string FirstName { get; }

        public string SecondName { get; }

        public override string ToString()
        {
            return $"Name: {FirstName} {SecondName} Id: {Id}";
        }
    }
}
