using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        /*public ContentResult Index2()
        {
            return Content("<h1>Robert <br> Cardiel</h1>");
            //return View();
        }

        public ViewResult Index()
        {
            return View("<h1>Robert <br> Cardiel</h1>");
            //return View();
        }*/
        public ActionResult Index()
        {
            var pulque = new Productos()
            {
                Nombre = "Pulque 3",
                Descripcion = "",
                Cantidad = 35,
                Produccion = new DateTime(2023, 5, 10)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
        }


        public RedirectResult vista()
        {
            return Redirect("http://google.com.mx");
        }
        public RedirectToRouteResult Vista2()
        {
            ViewData["Nombre"] = "Robet";
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DW";

            string nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.valor = nombre;
            return View();
        }
        /*SIRVE PA PASAR VALORES
        ViewBag
        ViewData
        TempData*/

        
        public ActionResult CalcularDistancia(CalcularDistancia CD)
        {
            var model = new CalcularDistancia();
            //ViewBag.distancia = model.Calcular(CD.X1, CD.Y1, CD.X2, CD.Y2);
            if (!string.IsNullOrEmpty(CD.X1.ToString()) &&
                !string.IsNullOrEmpty(CD.Y1.ToString()) &&
                !string.IsNullOrEmpty(CD.X2.ToString()) &&
                !string.IsNullOrEmpty(CD.Y2.ToString())
                )
            {
                ViewBag.Resultado = "El resultado es: " +model.Calcular(CD.X1, CD.Y1, CD.X2, CD.Y2);
                
            } else {
                ViewBag.Resultado = "No hay resultado, aun";
            }
            return View();
        }


    }
}