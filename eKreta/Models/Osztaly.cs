using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta.Models
{
    public class Osztaly
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string OsztalyNev { get; set; }
        public int TeremId { get; set; }

        public Osztaly(string osztalyNev, int teremId)
        {
            OsztalyNev = osztalyNev;
            TeremId = teremId;
        }

        public Osztaly()
        {
        }
    }
}
