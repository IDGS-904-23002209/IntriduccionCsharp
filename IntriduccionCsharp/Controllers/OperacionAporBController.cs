using IntriduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntriduccionCsharp.Controllers
{
    public class OperacionAporBController : Controller
    {
        public ActionResult SumaAporB(OperacionAporB Suma)
        {
            Suma.Operacion();

            return View(Suma);
        }
    }
}

