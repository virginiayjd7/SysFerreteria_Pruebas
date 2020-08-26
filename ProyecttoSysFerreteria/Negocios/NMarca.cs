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
   public class NMarca
    {
        protected bool Response = false;
        public bool Agregar(EMarca obj)
        {
            SQLParameter[] parameters = new SQLParameter[1];
            parameters[0] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarMarca", parameters);
            return Response;
        }
        public bool Modificar(EMarca obj)
        {
            SQLParameter[] parameters = new SQLParameter[2];
            parameters[0] = new SQLParameter("@ID", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarMarca", parameters);
            return Response;
        }
        public List<EMarca> Listar()
        {
            List<EMarca> List = new List<EMarca>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarMarca").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                EMarca be = new EMarca
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Nombre = row["Nombre"].ToString()
                };
                List.Add(be);
            }
            return List;
        }
        public Dictionary<int, string> CuadroCombinado()
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (Listar().Count > 0)
            {
                foreach (EMarca item in Listar())
                {
                    Lista.Add(item.ID, item.Nombre);
                }
                return Lista;
            }
            return Lista;
        }
    }
}