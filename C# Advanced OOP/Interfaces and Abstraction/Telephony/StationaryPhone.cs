using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICalleble
    {
        public StationaryPhone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; private set; }

        public string Call(string phoneNumber)
        {
            if (this.IsNumberValid(phoneNumber))
            {
                return $"Dialing... {phoneNumber}";
            }
            return "Invalid number!";
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
