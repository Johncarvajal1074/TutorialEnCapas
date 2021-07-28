using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_PROYECTOS.Controllers
{
    public class ProyectoController : Controller
    {
        // GET: Proyecto
        public ActionResult Index()
        {
            try
            {
                var proyectos = ProyectoCN.ListarProyectos();
                return View(proyectos);
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", "Error al mostrar Proyectos");
                return View();
            }

        }

        public ActionResult CrearProyecto()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearProyecto(Proyecto _proyecto)
        {
            try
            {
                if (_proyecto.NombreProyecto == null)
                {                    
                    return Json(new { ok = false, msg = "Debe ingresar el nombre del proyecto" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    
                ProyectoCN.CrearProyecto(_proyecto);
                    
                    return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);
                    //return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError("", "Error al Crear Proyecto");
                //return View("Index");
            }
            
        }
    }
}