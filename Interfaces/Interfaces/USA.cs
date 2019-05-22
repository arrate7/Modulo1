using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class USA : IPostCode
    {
        public bool IsValid(string postcode)
        {
            if (postcode.Length < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Region(string postcode)
        {
            return postcode;
        }
    }
}
