using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    interface IValue
    {

        public String Number { get; set; }
        public double Summ { get; set; }
        public String GetInfoForOrg();

    }
}
