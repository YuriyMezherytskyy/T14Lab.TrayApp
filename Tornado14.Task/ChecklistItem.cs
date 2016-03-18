using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    public class ChecklistItem
    {
        public bool SetupJa { get; set; }
        public Resultat SetupJaFunktion { get; set; }
        public string Nummer { get; set; }
        public bool Ja { get; set; }
        public string Aufgabe { get; set; }
        public Hilfe Hilfe { get; set; }
        public string Parameter { get; set; }
        public Funktion Funktion { get; set; }
        public string Resultat { get; set; }
        public bool Versteckt { get; set; }
    }
}
