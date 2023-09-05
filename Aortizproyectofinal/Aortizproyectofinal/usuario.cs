using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aortizproyectofinal
{
    public class usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Usuario { get; set; }

        [MaxLength(50)]
        public string Contraseña { get; set; }
    }
}
