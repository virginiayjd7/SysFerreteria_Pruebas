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
    public class NProveedor
    {
        protected bool Response = false;
        public bool Agregar(EProveedor obj)
        {
            SQLParameter[] parameters = new SQLParameter[6];
            parameters[0] = new SQLParameter("@Ruc", obj.Ruc, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@RazonSocial", obj.RazonSocial, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarProveedor", parameters);
            return Response;
        }
        public bool Modificar(EProveedor obj)
        {
            SQLParameter[] parameters = new SQLParameter[6];
            parameters[0] = new SQLParameter("@Ruc", obj.Ruc, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@RazonSocial", obj.RazonSocial, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarProveedor", parameters);
            return Response;
        }
        public List<EProveedor> Listar()
        {
            List<EProveedor> List = new List<EProveedor>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarProveedor").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EProveedor be = new EProveedor
                    {
                        ID = Convert.ToInt32(row[0]),
                        Ruc = row[1].ToString(),
                        RazonSocial = row[2].ToString(),
                        Ciudad = row[3].ToString(),
                        Direccion = row[4].ToString(),
                        Email = row[5].ToString(),
                        Telefono = row[6].ToString()
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
        public EProveedor Seleccionar(string Ruc)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Ruc", Ruc, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarProveedor", parameters).Tables[0].Rows[0];
                EProveedor be = new EProveedor
                {
                    ID = Convert.ToInt32(row[0]),
                    Ruc = row[1].ToString(),
                    RazonSocial = row[2].ToString(),
                    Ciudad = row[3].ToString(),
                    Direccion = row[4].ToString(),
                    Email = row[5].ToString(),
                    Telefono = row[6].ToString()
                };
                return be;
            }
            catch
            {
                EProveedor be = new EProveedor();
                return be;
            }
        }

        public List<EProveedor> Buscar(string KeyWoard)
        {
            List<EProveedor> List = new List<EProveedor>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@KeyWoard", KeyWoard, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_BuscarProveedor", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EProveedor be = new EProveedor
                    {
                        ID = Convert.ToInt32(row[0]),
                        Ruc = row[1].ToString(),
                        RazonSocial = row[2].ToString(),
                        Ciudad = row[3].ToString(),
                        Direccion = row[4].ToString(),
                        Email = row[5].ToString(),
                        Telefono = row[6].ToString()
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
    }
}
