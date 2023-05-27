using IDGS904_tema1.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class TraductorServices
    {
        public void GuardarArvchivo(TraductorEntrada maes) {
            var datosE = maes.ESP +Environment.NewLine;
            var datosI = maes.ING + Environment.NewLine;

            var archivoE = HttpContext.Current.Server.MapPath("~/App_Data/TraductorESP.txt");
            var archivoI = HttpContext.Current.Server.MapPath("~/App_Data/TraductorING.txt");

            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivoE, datosE);
            File.AppendAllText(archivoI, datosI);
        }

        public Array LeerArchivoE()
        {
            Array datosE = null;
            var archivoE = HttpContext.Current.Server.MapPath("~/App_Data/TraductorESP.txt");
            if (File.Exists(archivoE)){ datosE = File.ReadAllLines(archivoE);}
            return datosE;
        }
        public Array LeerArchivoI()
        {
            Array datosI = null;
            var archivoI = HttpContext.Current.Server.MapPath("~/App_Data/TraductorING.txt");
            if (File.Exists(archivoI)) { datosI = File.ReadAllLines(archivoI); }
            return datosI;
        }
    }
}