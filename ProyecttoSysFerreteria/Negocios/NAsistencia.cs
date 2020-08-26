using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyecttoSysFerreteria.Entidad;

namespace ProyecttoSysFerreteria.Negocios
{
   public  class NAsistencia
    {

        protected bool Response = false;
        public bool Agregar(EAsistencia obj)
        {
            SQLParameter[] parameters = new SQLParameter[1];
            parameters[0] = new SQLParameter("ID", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@hora_inicio", obj.Hora_Entrada, SqlDbType.DateTime);
            parameters[2] = new SQLParameter("@hora_salida", obj.Hora_Salida, SqlDbType.DateTime);
            parameters[3] = new SQLParameter("@Año", obj.Año, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@fecha", obj.Mes, SqlDbType.DateTime);
            parameters[5] = new SQLParameter("@Mes", obj.Mes, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarAsistencia", parameters);
            return Response;
        }
        public List<EAsistencia> Listar()
        {
            List<EAsistencia> List = new List<EAsistencia>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarDetalle_Asistencia").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EAsistencia be = new EAsistencia
                    {
                        ID = Convert.ToInt32(row[0]),
                      
                    };
                    List.Add(be);
                }
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return List;
        }
        public bool Modificar(EAsistencia obj)
        {
            SQLParameter[] parameters = new SQLParameter[2];
            parameters[0] = new SQLParameter("@ID_asistencia", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@hora_inicio", obj.Hora_Entrada, SqlDbType.DateTime);
            
            Response = Conexion.ExecuteProcedureB("USP_U_ActualizarSalida", parameters);
            return Response;
        }
    }
}
