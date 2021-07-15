using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string secondName, 
            decimal salary, SouldierCorpEnum corp, ICollection<IRepair> repairs) 
            : base(id, firstName, secondName, salary, corp)
        {
            this.Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get;  }
    }
}
