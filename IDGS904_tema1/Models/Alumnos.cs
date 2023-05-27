using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Alumnos
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public bool Activo{ get; set; }
        public DateTime Inscrito{ get; set; }
    }
}