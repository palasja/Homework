using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class ContractCraftman : IValue
    {
        public ContractCraftman(string number, double summ, int countProduct)
        {
            Number = number;
            Summ = summ;
            CountProduct = countProduct;
        }

        public string Number { get; set; }
        public double Summ { get; set; }
        public int CountProduct { get; set; }

        public string GetInfoForOrg()
        {
            return $"{Number} - {Summ}, {CountProduct} шт";
        }
    }
}
