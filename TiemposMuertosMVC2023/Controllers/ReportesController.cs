using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiemposMuertosMVC2023.Models;

namespace TiemposMuertosMVC2023.Controllers
{
    public class ReportesController : Controller
    {
        public ActionResult Seleccion()
        {
            return View();
        }

        public JsonResult getMaquinas()
        {
            Maquinas ma = new Maquinas();

            var lista = ma.getMaquinas();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TablaReportes()
        {
            return View();
        }

        public JsonResult getOrdenes()
        {
            Ordenes or = new Ordenes();

            var lista = or.getOrdenes();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}