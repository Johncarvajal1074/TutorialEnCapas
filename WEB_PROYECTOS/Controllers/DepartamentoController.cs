using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WEB_PROYECTOS.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            try
            {
                var dptos = DepartamentoCN.ListarDepartamentos();
                return View(dptos);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult DetalleDepartamento(int id)
        {
            try
            {
                var dpto = DepartamentoCN.GetDepartamento(id);
                return View(dpto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult CrearDepartamento()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearDepartamento(Departamento dpto)
        {
            try
            {
                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("", "Debe ingresar el nombre del Departamento");                    
                    return View(dpto);
                }
                DepartamentoCN.AgregarDepartamento(dpto);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al crear el Departamento");
                Console.WriteLine(ex.Message);
                return View(dpto);
            }
        }

        public ActionResult EditarDepartamento(int id)
        {
            var dpto = DepartamentoCN.GetDepartamento(id);
            return View(dpto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarDepartamento(Departamento dpto)
        {
            try
            {
                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("", "Debe ingresar el nombre del Departamento");
                    return View(dpto);
                }
                DepartamentoCN.EditarDepartamento(dpto);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al editar el departamento");
                Console.WriteLine(ex.Message);
                return View(dpto);
            }
        }

        public ActionResult EliminarDepartamento(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var dpto = DepartamentoCN.GetDepartamento(id.Value);
            return View(dpto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarDepartamento(int id)
        {
            try
            {
                DepartamentoCN.EliminarDepartamento(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al Eliminar el departamento");                
                return View();

            }
        }

    }
}