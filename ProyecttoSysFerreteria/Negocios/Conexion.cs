using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // metodo pata tener datatable rowf field
using System.Data.SqlClient; // conexion con sql
namespace ProyecttoSysFerreteria.Negocios
{
    public class Conexion
    {
       
        public static SqlConnection conexion;
        public  static SqlConnection AbrirConexion()
        {
            try
            {

                conexion = new SqlConnection("Data Source=(local);Initial Catalog=SysFerreteria;Integrated Security=True ");

                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    return conexion;
                }


            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir conexion", e);
            }

            return conexion;
        }

        public static void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar conexion", e);
            }
        }
        public static DataSet ExecuteProcedureD(string procedure, SQLParameter[] parameters = null)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = AbrirConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedure;
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i].Name, parameters[i].Type).Value = parameters[i].Value;
                    }
                }
                data.Fill(ds, "DataTable");
                CerrarConexion();
                return ds;
            }
            catch
            {
                return ds;
            }
        }
        public static bool ExecuteProcedureB(string procedure, SQLParameter[] parameters = null)
        {
            bool Response = false;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = AbrirConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedure;
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i].Name, parameters[i].Type).Value = parameters[i].Value;
                    }
                }
                Response = cmd.ExecuteNonQuery() > 0 ? true : false;
                CerrarConexion();
                return Response;
            }
            catch
            {
                return false;
            }
        }
    }
}
