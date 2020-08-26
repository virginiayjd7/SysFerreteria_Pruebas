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
    public class NUsuario
    {
        protected bool Response = false;
        public bool Agregar(EUsuario obj)
        {
            SQLParameter[] parameters = new SQLParameter[3];

            parameters[0] = new SQLParameter("@Username", obj.Username, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@Password", obj.Password, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Estado", obj.Estado, SqlDbType.Int);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarUsuario", parameters);
            return Response;
        }

        public EUsuario LoginUsuario(string Username, string Password)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Username", Username, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Password", Password, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_LoginUsuario", parameters).Tables[0].Rows[0];
                EUsuario be = new EUsuario
                {
                    ID = Convert.ToInt32(row[0]),
                    Username = row[1].ToString(),
                    Password = row[2].ToString(),
                    Estado = Convert.ToInt32(row[3])
                };
                return be;
            }
            catch
            {
                EUsuario be = new EUsuario();
                return be;
            }
        }

        public DataRow ObtenerPerfilBasico(string Username)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@NumeroDocumento", Username, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_PerfilBasicoUsuario", parameters).Tables[0].Rows[0];
                return row;
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                DataRow row = null;
                return row;
            }
        }

        public bool ChangePassword(string password, string newpassword, string codigo)
        {
            try
            {
                EUsuario be = LoginUsuario(codigo, password);
                if (be.Password != password)
                {
                    Response = false;
                }
                else
                {
                    SQLParameter[] parameters = new SQLParameter[2];
                    parameters[0] = new SQLParameter("@Username", codigo, SqlDbType.VarChar);
                    parameters[1] = new SQLParameter("@Password", newpassword, SqlDbType.VarChar);
                    Response = Conexion.ExecuteProcedureB("USP_U_CambiarClaveUsuario", parameters);
                }
                return Response;
            }
            catch
            {
                return Response = false;
            }
        }
    }
}
