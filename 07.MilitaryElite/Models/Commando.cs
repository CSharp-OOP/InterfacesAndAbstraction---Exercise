using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, IComando
    {
        public Commando(int id, string firstName, string secondName, 
            decimal salary, SouldierCorpEnum corp, ICollection<IMission> missions) 
            : base(id, firstName, secondName, salary, corp)
        {
            this.Missions = missions;
        }

        public ICollection<IMission> Missions { get; }
    }
}
