using ApiPeliculasAWS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPeliculasAWS.Models
{
    [Table("pelismysql")]
    public class Pelicula
    {
        [Key]
        [Column("IdPelicula")]
        public int IdPelicula { get; set; }

        [Column("Genero")]
        public string Genero { get; set; }

        [Column("Titulo")]
        public string Titulo { get; set; }

        [Column("Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Column("Argumento")]
        public string Argumento { get; set; }

        [Column("Actores")]
        public string Actores { get; set; }

        [Column("Duracion")]
        public int Duracion { get; set; }

        [Column("Precio")]
        public int Precio { get; set; }

        [Column("Youtube")]
        public string Youtube { get; set; }
    }
}
//IdPelicula int NOT NULL PRIMARY KEY,
//    Genero nvarchar(50) NULL,
//    Titulo nvarchar(255) NULL,
//    Nacionalidad nvarchar(50) NULL,
//    Argumento nvarchar(5000) NULL,
//    Actores nvarchar(5000) NOT NULL,
//    Duracion int NULL,
//    Precio int NULL,
//    Youtube nvarchar(255) NULL
