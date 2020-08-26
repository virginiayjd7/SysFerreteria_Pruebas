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
   public class NCargo
    {
        protected bool Response = false;
        public bool Agregar(ECargo obj)
        {
            SQLParameter[] parameters = new SQLParameter[1];
            parameters[0] = new SQLParameter("@Descripcion", obj.Descripcion, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarCargo", parameters);
            return Response;
        }
        public bool Modificar(ECargo obj)
        {
            SQLParameter[] parameters = new SQLParameter[2];
            parameters[0] = new SQLParameter("@ID", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Descripcion", obj.Descripcion, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarCargo", parameters);
            return Response;
        }
        public List<ECargo> Listar()
        {
            List<ECargo> List = new List<ECargo>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarCargo").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    ECargo be = new ECargo
                    {
                        ID = Convert.ToInt32(row[0]),
                        Descripcion = row[1].ToString()
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
        public ECargo Seleccionar(int Identificador)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@ID", Identificador, SqlDbType.Int);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarCargo", parameters).Tables[0].Rows[0];
                ECargo be = new ECargo
                {
                    ID = Convert.ToInt32(row[0]),
                    Descripcion = row[1].ToString()
                };
                return be;
            }
            catch
            {
                ECargo be = new ECargo();
                return be;
            }
        }
        public Dictionary<int, string> CuadroCombinado()
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (Listar().Count > 0)
            {
                foreach (ECargo item in Listar())
                {
                    Lista.Add(item.ID, item.Descripcion);
                }
                return Lista;
            }
            return Lista;
        }
    }
}
