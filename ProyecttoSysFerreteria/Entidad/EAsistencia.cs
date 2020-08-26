using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecttoSysFerreteria.Entidad
{
  public  class EAsistencia
    {
        public int ID_Asistencia { get; set; }
        public int ID { get; set; }
        public string Año { get; set; }
        public string Mes { get; set; }
        public string Hora_Entrada { get; set; }
        public string Hora_Salida { get; set; }
        public string fecha { get; set; }
    }
}
