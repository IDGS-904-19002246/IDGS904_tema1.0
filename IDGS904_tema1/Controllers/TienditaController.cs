using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace IDGS904_tema1.Controllers
{
    public class TienditaController : Controller
    {
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Nombre = "Pedro",
                Edad = 20,
                Activo = true,
                Inscrito = new DateTime(2023, 1, 1)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Registrar () {

            return View();
        }
        //TEMPERATURA (C° - F°)
        public ActionResult Temperatura(Temperatura T){
            var model = new Temperatura();
            if (T.Con == 0)
            {
                return View();
            }
            else {
                string fin = model.Convertir(T.Tem, T.Con);
                return RedirectToAction("TemperaturaFin",
                    new RouteValueDictionary(new { T = fin }));
            }
        }
        public ActionResult TemperaturaFin(string T)
        {
            ViewBag.Tem = T;
            return View();
        }
    }
}