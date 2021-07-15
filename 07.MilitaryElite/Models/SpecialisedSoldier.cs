using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, 
            string secondName, decimal salary, SouldierCorpEnum corp) 
            : base(id, firstName, secondName, salary)
        {
            this.Corp = corp;
        }

        public SouldierCorpEnum Corp { get; }
    }
}
