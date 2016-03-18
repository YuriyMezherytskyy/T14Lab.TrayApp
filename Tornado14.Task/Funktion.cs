using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    public class Funktion
    {
        public string Name { get; set; }
        public string Programm { get; set; }
        public string Parameter { get; set; }
        public List<Resultat> ResultatList { get; set; }

        public override string ToString()
        {
            return (String.IsNullOrEmpty(Name))? "" : Name;
        }
    }
}
