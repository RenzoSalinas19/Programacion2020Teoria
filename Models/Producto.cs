using System;

namespace Programacion2020Teoria.Models
{
    public class Producto
    {
        [Required]
        public string Nombre { get; set; }

        
        [Required]
        public int precio { get; set; }

        [Required]
        public string Descripcion { get; set; }

    }
}