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
        
        public static List<Proyecto> ListarProyectos()
        {
            return obj.ListarProyectos();
        }
             
    }
}
