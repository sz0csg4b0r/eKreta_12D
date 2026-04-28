using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta.Models
{
    public class Terem
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string TeremNev { get; set; }

        public Terem(string teremNev)
        {
            TeremNev = teremNev;
        }

        public Terem()
        {
        }
    }
}
