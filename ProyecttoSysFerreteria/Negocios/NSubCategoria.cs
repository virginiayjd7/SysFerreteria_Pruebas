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
    public class NSubCategoria
    {
        protected bool Response = false;
        public bool Agregar(ESubCategoria obj)
        {
            SQLParameter[] parameters = new SQLParameter[2];
            parameters[0] = new SQLParameter("@Categoria", obj.Categoria, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarSubCategoria", parameters);
            return Response;
        }
        public bool Modificar(ESubCategoria obj)
        {
            SQLParameter[] parameters = new SQLParameter[3];
            parameters[0] = new SQLParameter("@ID", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Categoria", obj.Categoria, SqlDbType.Int);
            parameters[2] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarSubCategoria", parameters);
            return Response;
        }
        public List<ESubCategoria> Listar()
        {
            List<ESubCategoria> List = new List<ESubCategoria>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarSubCategoria").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                ESubCategoria be = new ESubCategoria
                {
                    ID = Convert.ToInt32(row[0]),
                    Categoria = Convert.ToInt32(row[1]),
                    Nombre = row[2].ToString()
                };
                List.Add(be);
            }
            return List;
        }
        public List<ESubCategoria> ListarxCategoria(int categoria)
        {
            List<ESubCategoria> List = new List<ESubCategoria>();
            SQLParameter[] parameters = new SQLParameter[1];
            parameters[0] = new SQLParameter("@Categoria", categoria, SqlDbType.Int);
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarSubCategoriaxCategoria", parameters).Tables[0];
            foreach (DataRow row in data.Rows)
            {
                ESubCategoria be = new ESubCategoria
                {
                    ID = Convert.ToInt32(row[0]),
                    Categoria = Convert.ToInt32(row[1]),
                    Nombre = row[2].ToString()
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
                foreach (ESubCategoria item in Listar())
                {
                    Lista.Add(item.ID, item.Nombre);
                }
                return Lista;
            }
            return Lista;
        }
        public Dictionary<int, string> CuadroCombinadoxCategoria(int categoria)
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (ListarxCategoria(categoria).Count > 0)
            {
                foreach (ESubCategoria item in ListarxCategoria(categoria))
                {
                    Lista.Add(item.ID, item.Nombre);
                }
                return Lista;
            }
            return Lista;
        }
    }
}
