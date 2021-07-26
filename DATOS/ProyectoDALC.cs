using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ProyectoDALC
    {
        public void CrearProyecto(Proyecto _proyecto)
        {
            using(var db = new PROYECTOSDBEntities())
            {
                db.Proyecto.Add(_proyecto);
                db.SaveChanges();
            }
        }

        public List<Proyecto> ListarProyectos()
        {
            using(var db = new PROYECTOSDBEntities())
            {
                return db.Proyecto.ToList();
            }
        }
    }
}
