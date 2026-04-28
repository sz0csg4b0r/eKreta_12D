using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta.Models
{
    public class Felhasznalo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FelhasznaloNev { get; set; }
        public string TeljesNev { get; set; }
        public string Jelszo { get; set; }
        public int Jogosultsag { get; set; }

        public Felhasznalo()
        {
        }

        public Felhasznalo(string felhasznaloNev, string teljesNev, string jelszo, int jogosultsag)
        {
            FelhasznaloNev = felhasznaloNev;
            TeljesNev = teljesNev;
            Jelszo = jelszo;
            Jogosultsag = jogosultsag;
        }
    }
}
