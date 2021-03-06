using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalleble, IBrowseble
    {
        public Smartphone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; private set;  }

        public string Browse(string url)
        {
            if (this.IsUrlValid(url))
            {
                return $"Browsing: {url}!";
            }
            return "Invalid URL!";
        }

        public string Call(string phoneNumber)
        {
            if (this.IsNumberValid(phoneNumber))
            {
                return $"Calling... {phoneNumber}";
            }
            return "Invalid number!";
        }
        private bool IsUrlValid(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsNumberValid(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
