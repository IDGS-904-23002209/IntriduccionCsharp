using IntriduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntriduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult Distancia(Distancia dis)
        {
            dis.calcularDistancia();

            return View(dis);
        }
    }
}
