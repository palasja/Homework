using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Craftman : IKey
    {
        public Craftman(string name, int unp, string fIO)
        {
            Name = name;
            Unp = unp;
            FIO = fIO;
        }

        public string Name { get; set; }
        public int Unp {get; set; }
        public String FIO { get; set; }
        public string GetFullName()
        {
            return $"{Unp} - {Name} : {FIO}";
        }
    }
}
