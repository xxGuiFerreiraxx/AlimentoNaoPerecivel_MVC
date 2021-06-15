using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlimentoNaoPerecivel.Models;

namespace AlimentoNaoPerecivel.Controllers
{
    public class AlimentoController : Controller
    {
        // GET: Alimento
        public ActionResult Index()
        {
            var alimento = new Alimento();
            return View();
        }
        [HttpPost]

        public ActionResult Index(Alimento alimento)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", alimento);
            }
            return View(alimento);
        }
        public ActionResult Resultado (Alimento alimento)
        {
            
            
                return View("Resultado", alimento);
           
          
        }

        public ActionResult LoginUnico(string codigo)
        {
            var bdAlimento = new Collection<string>
            {
                "4",
                "9"
            };
            return Json(bdAlimento.All(x => x.ToLower() != codigo.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}