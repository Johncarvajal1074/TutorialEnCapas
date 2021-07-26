using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class ProyectoCN
    {
        public static ProyectoDALC obj = new ProyectoDALC();

        public static void CrearProyecto(Proyecto _proyecto)
        {
            obj.CrearProyecto(_proyecto);
        }

            public static List<Proyecto> ListarProyectos()
        {
            return obj.ListarProyectos();
        }
             
    }
}
