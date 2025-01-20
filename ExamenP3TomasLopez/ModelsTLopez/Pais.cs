using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ExamenP3TomasLopez.ModelsTLopez
{
    [Table ("Pais")]
    public class Pais
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Nombre { get; set; }
        public string Region { get; set; }
        public string Link { get; set; }
        public string TLopez { get; set; }
    }
}
