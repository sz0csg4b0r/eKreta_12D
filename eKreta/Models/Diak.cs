using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta.Models
{
    public class Diak
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string VezNev { get; set; }
        public string UtoNev { get; set; }
        public string SzulDate { get; set; }
        public string AnyjaNeve { get; set; }
        public string Lakcim {  get; set; }

        public Diak(string vezNev, string utoNev, string szulDate, string anyjaNeve, string lakcim)
        {
            VezNev = vezNev;
            UtoNev = utoNev;
            SzulDate = szulDate;
            AnyjaNeve = anyjaNeve;
            Lakcim = lakcim;
        }

        public Diak()
        {
        }
    }
}
