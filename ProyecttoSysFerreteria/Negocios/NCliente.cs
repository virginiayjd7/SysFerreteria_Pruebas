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
    public class NCliente
    {
        protected bool Response = false;
        public bool Agregar(ECliente obj)
        {
            SQLParameter[] parameters = new SQLParameter[11];
            parameters[0] = new SQLParameter("@TipoDocumentoIdentidad", obj.TipoDocumento, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@NumeroDocumento", obj.NumeroDocumento, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Apellido", obj.Apellido, SqlDbType.VarChar);
            if (obj.FechaNacimiento.HasValue)
            {
                parameters[4] = new SQLParameter("@FechaNacimiento", obj.FechaNacimiento, SqlDbType.Date);
            }
            else
            {
                parameters[4] = new SQLParameter("@FechaNacimiento", DBNull.Value, SqlDbType.Date);
            }
            parameters[5] = new SQLParameter("@Pais", obj.Pais, SqlDbType.VarChar);
            parameters[6] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[7] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[8] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[9] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            parameters[10] = new SQLParameter("@Estado", obj.Estado, SqlDbType.Int);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarCliente", parameters);
            return Response;
        }
        public bool Modificar(ECliente obj)
        {
            SQLParameter[] parameters = new SQLParameter[9];
            parameters[0] = new SQLParameter("@NumeroDocumento", obj.NumeroDocumento, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Apellido", obj.Apellido, SqlDbType.VarChar);
            if (obj.FechaNacimiento.HasValue)
            {
                parameters[3] = new SQLParameter("@FechaNacimiento", obj.FechaNacimiento, SqlDbType.Date);
            }
            else
            {
                parameters[3] = new SQLParameter("@FechaNacimiento", DBNull.Value, SqlDbType.Date);
            }
            parameters[4] = new SQLParameter("@Pais", obj.Pais, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[6] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[7] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[8] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarCliente", parameters);
            return Response;
        }
        public List<ECliente> Listar()
        {
            List<ECliente> List = new List<ECliente>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarCliente").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    ECliente be = new ECliente
                    {
                        ID = Convert.ToInt32(row[0]),
                        TipoDocumento = row[1].ToString(),
                        NumeroDocumento = row[2].ToString(),
                        Nombre = row[3].ToString(),
                        Apellido = row[4].ToString(),
                        FechaNacimiento = row[5] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row[5]),
                        Pais = row[6].ToString(),
                        Ciudad = row[7].ToString(),
                        Direccion = row[8].ToString(),
                        Email = row[9].ToString(),
                        Telefono = row[10].ToString(),
                        Estado = Convert.ToInt32(row[11].ToString())
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
        public ECliente Seleccionar(string NumeroDocumento)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@NumeroDocumento", NumeroDocumento, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarCliente", parameters).Tables[0].Rows[0];
                ECliente be = new ECliente
                {
                    ID = Convert.ToInt32(row[0]),
                    TipoDocumento = row[1].ToString(),
                    NumeroDocumento = row[2].ToString(),
                    Nombre = row[3].ToString(),
                    Apellido = row[4].ToString(),
                    FechaNacimiento = row[5] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row[5]),
                    Pais = row[6].ToString(),
                    Ciudad = row[7].ToString(),
                    Direccion = row[8].ToString(),
                    Email = row[9].ToString(),
                    Telefono = row[10].ToString(),
                    Estado = Convert.ToInt32(row[11].ToString())
                };
                return be;
            }
            catch
            {
                ECliente be = new ECliente();
                return be;
            }
        }
        public bool VerificarNumeroDocumento(string NumeroDocumento)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@NumeroDocumento", NumeroDocumento, SqlDbType.VarChar);
                DataRow data = Conexion.ExecuteProcedureD("USP_S_VerificarNumeroDocumentoCliente", parameters).Tables[0].Rows[0];
                int cantidad = Convert.ToInt32(data[0]);
                if (cantidad == 0)
                {
                    Response = true;
                }
                else
                {
                    Response = false;
                }
            }
            catch
            {
                Response = false;
            }
            return Response;
        }

        public List<ECliente> Buscar(string KeyWoard)
        {
            List<ECliente> List = new List<ECliente>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@KeyWoard", KeyWoard, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_BuscarCliente", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    ECliente be = new ECliente
                    {
                        ID = Convert.ToInt32(row[0]),
                        TipoDocumento = row[1].ToString(),
                        NumeroDocumento = row[2].ToString(),
                        Nombre = row[3].ToString(),
                        Apellido = row[4].ToString(),
                        FechaNacimiento = row[5] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row[5]),
                        Pais = row[6].ToString(),
                        Ciudad = row[7].ToString(),
                        Direccion = row[8].ToString(),
                        Email = row[9].ToString(),
                        Telefono = row[10].ToString(),
                        Estado = Convert.ToInt32(row[11].ToString())
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
