using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCrud.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        public string? Nombre { get; set; }
        public Double Precio { get; set; }
    }
}