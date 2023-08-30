using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftRapidBus.DB
{
    public class Terminal
    {
        [PrimaryKey, AutoIncrement]
        public int id_ter { get; set; }
        [MaxLength(20)]
        public string nom_ter { get; set; }
        [MaxLength(35)]
        public string dir_ter { get; set; }

        [MaxLength(11)]
        public string cel_ter { get; set; }
    }
}
