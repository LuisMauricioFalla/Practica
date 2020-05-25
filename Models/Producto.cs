using System;

namespace PM___PRACTICA___Mauricio_Falla.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Foto { get; set; }
        public Boolean enPromocio { get; set; }
    }
}