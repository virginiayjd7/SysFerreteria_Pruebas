using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecttoSysFerreteria.Entidad
{
   public class EInventario
    {
        public int ID { get; set; }
        public string Producto { get; set; }
        public double ValorUnitario { get; set; }
        public int Existencias { get; set; }
        public double ValorInventario { get; set; }
    }
}
