using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    interface IKey
    {
        String Name { get; set; }
        int Unp { get; set; }

        String GetFullName();
    }
}
