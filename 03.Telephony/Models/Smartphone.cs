using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }
        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }
    }
}
