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
   public class NCategoria
    {
        protected bool Response = false;
        public bool Agregar(ECategoria obj)
        {
            SQLParameter[] parameters = new SQLParameter[1];
            parameters[0] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarCategoria", parameters);
            return Response;
        }
        public bool Modificar(ECategoria obj)
        {
            SQLParameter[] parameters = new SQLParameter[2];
            parameters[0] = new SQLParameter("@ID", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarCategoria", parameters);
            return Response;
        }
        public List<ECategoria> Listar()
        {
            List<ECategoria> List = new List<ECategoria>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarCategoria").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    ECategoria be = new ECategoria
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Nombre = row["Nombre"].ToString()
                    };
                    List.Add(be);
                }
            }
            catch
            {
                Console.WriteLine("No se ha encontrado Procedimiento Almacenado");
            }
            return List;
        }
        public Dictionary<int, string> CuadroCombinado()
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (Listar().Count > 0)
            {
                foreach (ECategoria item in Listar())
                {
                    Lista.Add(item.ID, item.Nombre);
                }
                return Lista;
            }
            return Lista;
        }
    }
}

