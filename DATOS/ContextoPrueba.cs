using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    class ContextoPrueba : DbContext
    {
        public ContextoPrueba() : base("Contexto")
        {
            Database.SetInitializer<ContextoPrueba>(null);
        }

        //public DbSet<Departamento> Departamentos { get; set; }
    }
}
