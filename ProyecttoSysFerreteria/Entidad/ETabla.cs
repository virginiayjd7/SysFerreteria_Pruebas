using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecttoSysFerreteria.Entidad
{
    public abstract class ETabla
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
