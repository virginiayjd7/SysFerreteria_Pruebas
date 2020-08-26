using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecttoSysFerreteria.Entidad
{
    public class EVenta
    {
        public int ID { get; set; }
        public int Cliente { get; set; }
        public int Empleado { get; set; }
        public string TipoComprobante { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public double SubTotal { get; set; }
        public double Igv { get; set; }
        public double Total { get; set; }
        public int Estado { get; set; }

        public List<EDetalleVenta> ListaDetalleProducto { get; set; }
        public double CalcularTotalPorIngresoDeProducto()
        {
            double total = 0;
            foreach (EDetalleVenta detalleProducto in ListaDetalleProducto)
            {
                if (detalleProducto.Cantidad >0)
                    total = (double)detalleProducto.Precio * detalleProducto.Cantidad;
            }
            return total;
        }
    }
}
