using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBiblioteca.Entities
{
    public class Autor
    {
        [Display (Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Nombre del Autor")]
        public string Name { get; set; }
    }
}
