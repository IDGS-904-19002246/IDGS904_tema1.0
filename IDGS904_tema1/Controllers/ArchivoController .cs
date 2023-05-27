using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers{
    public class ArchivoController : Controller{
        
        public ActionResult Registrar(){
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Maestros maes){
            var ope1 = new GuardarServices();
            ope1.GuardarArvchivo(maes);
            return View();
        }
        public ActionResult LeerDatos()
        {
            var arch= new LeerServices();
            ViewBag.Archivo = arch.LeerArchivo();
            return View();
        }
    }
}