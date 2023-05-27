using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ProductoServices
    {
        public List<Productos> ObtenerProductos() {
            
            var pro1 = new Productos()
            {
                Nombre = "Pulque 1",
                Descripcion = "",
                Cantidad = 35,
                Produccion = new DateTime(2023, 5, 10)
            };
            var pro2 = new Productos()
            {
                Nombre = "Pulque 2",
                Descripcion = "",
                Cantidad = 35,
                Produccion = new DateTime(2023, 5, 10)
            };
            var pro3 = new Productos()
            {
                Nombre = "Pulque 3",
                Descripcion = "",
                Cantidad = 35,
                Produccion = new DateTime(2023, 5, 10)
            };
            return new List<Productos>() { pro1, pro2, pro3 };
        }
    }
    
}