using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IPostCode
    {
        bool IsValid(string postcode);
        string Region(string postcode);

    }
}
