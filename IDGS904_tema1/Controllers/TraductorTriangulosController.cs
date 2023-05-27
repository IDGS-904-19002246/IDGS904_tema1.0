using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.Data;
using System.Xml.Linq;

namespace IDGS904_tema1.Controllers{
    public class TraductorTriangulosController : Controller{

        public ActionResult TraductorEntrada(){
            var arch = new TraductorServices();
            Array E = arch.LeerArchivoE();
            Array I = arch.LeerArchivoI();
            ViewBag.E = E;
            ViewBag.I = I;
            return View();
        }
        [HttpPost]
        public ActionResult TraductorEntrada(TraductorEntrada T){
            var tr = new TraductorServices();
            tr.GuardarArvchivo(T);
            return RedirectToAction("TraductorEntrada");
            //return View();
        }
        public ActionResult TraductorSalida(TraductorEntrada T)
        {
            var arch = new TraductorServices();
            if (T.IDIOMA == 0){return RedirectToAction("TraductorEntrada");}

            Array E = arch.LeerArchivoE();
            Array I = arch.LeerArchivoI();
            String palabra = null;
            String idioma = null;

            if (T.IDIOMA == 1) {
                idioma = "Español";
                foreach (string item in I){
                    palabra = (item == T.PAL ? (string)E.GetValue(Array.IndexOf(I, item)) : palabra);
                }
            }
            if (T.IDIOMA == 2) {
                idioma = "Ingles";
                foreach (string item in E){
                    palabra = (item == T.PAL ? (string)I.GetValue(Array.IndexOf(E, item)): palabra);
                }
            }

            if (palabra == null){ViewBag.palabra = "Palabra no encontrada";}
            else{ViewBag.palabra = "La palabra '" + T.PAL + "'" + " traducida al " + idioma + " es '" + palabra + "' :D";}

            return View();
        }

        public ActionResult Triangulos(){return View();}
        [HttpPost]
        public ActionResult Triangulos(Triangulos Tri)
        {
            var triangulo = new Triangulos();
            double AB = Math.Round(triangulo.Calcular(Tri.X1, Tri.Y1, Tri.X2, Tri.Y2),3);
            double BC = Math.Round(triangulo.Calcular(Tri.X2, Tri.Y2, Tri.X3, Tri.Y3),3);
            double CA = Math.Round(triangulo.Calcular(Tri.X3, Tri.Y3, Tri.X1, Tri.Y1),3);

            // Fórmula de Herón
            double semiperimetro = (AB + BC + CA) / 2;
            
            double[] L = { AB, BC, CA };
            Array.Sort(L);
            string tipo = "";
            double area = 0.0;
            if (L[2] >= (L[1] + L[0])) {
                tipo = "No es triangulo";
            }
            else {
                if (AB != BC && BC != CA && CA != AB) { tipo = "Escaleno"; }
                if (AB == BC || BC == CA || CA == AB) { tipo = "Isoseles"; }
                if (AB == BC && BC == CA && CA == AB) { tipo = "Equilatelo"; }
                area = Math.Round(
                    Math.Sqrt(
                    semiperimetro *
                    (semiperimetro - AB) *
                    (semiperimetro - BC) *
                    (semiperimetro - CA)), 3);
            }



            if (tipo == "No es triangulo")
            {
                ViewBag.Area = "No hay área";
            }
            else {
                ViewBag.Area = area;
            }
            ViewBag.Tipo = tipo;
            ViewBag.Lados = L[0]+", "+L[1]+" y "+L[2];
            //(AB == BC ? "":"");
            return View();
        }
    }

}