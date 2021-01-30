using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Contract : IValue
    {
        public Contract(string number, int innerNum, double summ)
        {
            Number = number;
            InnerNum = innerNum;
            Summ = summ;
        }

        public String Number { get; set; }
        public int InnerNum { get; set; }
        public double Summ { get; set; }


        public string GetInfoForOrg()
        {
            return $"{Number} - {Summ}";
        }
        public string GetFullInfo()
        {
            return $"InnerNumber:{InnerNum} \t Numver:{Number} \t Summ:{Summ}";
        }
    }
}
