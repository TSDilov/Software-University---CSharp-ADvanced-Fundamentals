using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ICalleble
    {
        public string PhoneNumber { get; }
        string Call(string phoneNumber);
    }
}
