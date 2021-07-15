using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, 
            string secondName, decimal salary, 
            ICollection<IPrivate> privates) 
            : base(id, firstName, secondName, salary)
        {
            this.Privates = privates;
        }

        public ICollection<IPrivate> Privates { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()} Salary: {Math.Round(Salary, 2):F2}");
            sb.AppendLine("Privates:");
            foreach (var item in Privates)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
