using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecttoSysFerreteria.Entidad
{
    public class EMovimiento
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoComprobante { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string TipoOperacion { get; set; }
        public string Producto { get; set; }
        public int CantidadEntrada { get; set; }
        public double CostoUnitarioEntrada { get; set; }
        public double CostoTotalEntrada { get; set; }
        public int CantidadSalida { get; set; }
        public double CostoUnitarioSalida { get; set; }
        public double CostoTotalSalida { get; set; }
        public int CantidadFinal { get; set; }
        public double CostoUnitarioFinal { get; set; }
        public double CostoTotalFinal { get; set; }
    }
}
