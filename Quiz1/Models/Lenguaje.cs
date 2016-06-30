using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quiz1.Models
{
    [Table("Lenguajes")]
    public class Lenguaje
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}