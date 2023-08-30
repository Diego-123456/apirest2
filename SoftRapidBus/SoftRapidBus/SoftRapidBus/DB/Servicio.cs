using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftRapidBus.DB
{
    public class Servicio
    {

        [PrimaryKey, AutoIncrement]
        public int id_Ser { get; set; }
        [MaxLength(20)]
        public string nom_Ser { get; set; }
        [MaxLength(35)]
        public string Precio_Ser { get; set; }

        [MaxLength(11)]
        public string Num_Ser { get; set; }

    }
}