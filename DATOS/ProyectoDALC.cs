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
        public List<Proyecto> ListarProyectos()
        {
            using(var db = new PROYECTOSDBEntities())
            {
                return db.Proyecto.ToList();
            }
        }
    }
}
