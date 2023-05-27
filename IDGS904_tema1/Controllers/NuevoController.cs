using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class NuevoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.nombre = "Mombre";
            return View();
        }

        public ActionResult Vista(string n1, string n2)
        {
            int res = Convert.ToInt32(n1) + Convert.ToInt32(n2);
            ViewBag.res = res;
            return View();
        }
        public ActionResult Calcular(OperasBas op)
        {
            var model = new OperasBas();
            model.FIN(op.Num1 ,op.Num2, op.opcion);
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques = new ProductoServices();
            var model = pulques.ObtenerProductos();

            return View(model);
        }

    }
}