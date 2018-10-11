using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tallerapis.apis.Models
{
    [Table("tblPublicacion")]
    public class tblpublicacion
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        [Required]
        public int MeGusta { get; set; }
        [Required]
        public int MeDisgusta { get; set; }
        [Required]
        public int VecesCompartido { get; set; }
        public bool EsPrivada { get; set; }
    }
}