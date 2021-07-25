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

                throw ex;
            }
            
        }
    }
}