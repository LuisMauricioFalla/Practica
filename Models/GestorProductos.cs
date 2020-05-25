using System.Collections.Generic;

namespace PM___PRACTICA___Mauricio_Falla.Models
{
    public class GestorProductos
    {
        public List<Producto> Listado(){
            var Productos = new List<Producto>();

            Productos.Add(new Producto{
                ID=1,
                Nombre = "Camara",
                Precio = 500,
                Foto = "/CAMARA.jpg",
                enPromocio = true
                });

            Productos.Add(new Producto{
                ID=2,
                Nombre = "Laptop",
                Precio = 1000,
                Foto = "/LAPTOP.jpg",
                enPromocio = true
            });

            Productos.Add(new Producto{
                ID=3,
                Nombre = "Desktop",
                Precio = 1500,
                Foto = "/DESKTOP.jpg",
                enPromocio = true
            });
            
            return Productos;
        }
    }
}