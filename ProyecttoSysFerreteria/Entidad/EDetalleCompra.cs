using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecttoSysFerreteria.Entidad
{
   public class EDetalleCompra
    {
        public int ID { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string Producto { get; set; }
        public double PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public double PrecioTotal { get; set; }

    }
}
