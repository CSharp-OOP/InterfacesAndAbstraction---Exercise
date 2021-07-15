using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Interfaces
{
    public interface IComando
    {
        public ICollection<IMission> Missions { get; }
    }
}
