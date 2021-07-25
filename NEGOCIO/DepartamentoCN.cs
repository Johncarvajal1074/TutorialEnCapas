using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class DepartamentoCN
    {
        public static DepartamentoDALC obj = new DepartamentoDALC();

        public static void EliminarDepartamento(int id)
        {
            obj.EliminarDepartamento(id);
        }

        public static void EditarDepartamento(Departamento dpto)
        {
            obj.EditarDepartamento(dpto);
        }

            public static Departamento GetDepartamento(int id)
        {
            return obj.GetDepartamento(id);
        }

            public static void AgregarDepartamento(Departamento dpto)
        {
            obj.CrearDepartamento(dpto);
        }
            public static List<Departamento> ListarDepartamentos()
        {
            return obj.ListarDepartamentos();
        }
    }
}
