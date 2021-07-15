using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dialing... {phoneNumber}";
        }
    }
}
