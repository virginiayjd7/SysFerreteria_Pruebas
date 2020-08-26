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
   public class NEmpleado
    {
        protected bool Response = false;
        public bool Agregar(EEmpleado obj)
        {
            SQLParameter[] parameters = new SQLParameter[12];
            parameters[0] = new SQLParameter("@Cargo", obj.Cargo, SqlDbType.Int);
            parameters[1] = new SQLParameter("@TipoDocumentoIdentidad", obj.TipoDocumento, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@NumeroDocumento", obj.NumeroDocumento, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Apellido", obj.Apellido, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@FechaNacimiento", obj.FechaNacimiento, SqlDbType.Date);
            parameters[6] = new SQLParameter("@Pais", obj.Pais, SqlDbType.VarChar);
            parameters[7] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[8] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[9] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[10] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            parameters[11] = new SQLParameter("@Estado", obj.Estado, SqlDbType.Int);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarEmpleado", parameters);
            //Agregar Usuario
            if (Response == true)
            {
                EUsuario beUsuario = new EUsuario
                {
                    Username = obj.NumeroDocumento,
                    Password = obj.NumeroDocumento,
                    Estado = 1
                };
                NUsuario boUsuario = new NUsuario();
                boUsuario.Agregar(beUsuario);
            }
            return Response;
        }
        public bool Modificar(EEmpleado obj)
        {
            SQLParameter[] parameters = new SQLParameter[10];
            parameters[0] = new SQLParameter("@Cargo", obj.Cargo, SqlDbType.Int);
            parameters[1] = new SQLParameter("@NumeroDocumento", obj.NumeroDocumento, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Apellido", obj.Apellido, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@FechaNacimiento", obj.FechaNacimiento, SqlDbType.Date);
            parameters[5] = new SQLParameter("@Pais", obj.Pais, SqlDbType.VarChar);
            parameters[6] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[7] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[8] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[9] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarEmpleado", parameters);
            return Response;
        }
        public List<EEmpleado> Listar()
        {
            List<EEmpleado> List = new List<EEmpleado>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarEmpleado").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EEmpleado be = new EEmpleado
                    {
                        ID = Convert.ToInt32(row[0]),
                        Cargo = Convert.ToInt32(row[1]),
                        TipoDocumento = row[2].ToString(),
                        NumeroDocumento = row[3].ToString(),
                        Nombre = row[4].ToString(),
                        Apellido = row[5].ToString(),
                        FechaNacimiento = Convert.ToDateTime(row[6]),
                        Pais = row[7].ToString(),
                        Ciudad = row[8].ToString(),
                        Direccion = row[9].ToString(),
                        Email = row[10].ToString(),
                        Telefono = row[11].ToString(),
                        Estado = Convert.ToInt32(row[12])
                    };
                    List.Add(be);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return List;
        }
        public EEmpleado Seleccionar(string NumeroDocumento)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@NumeroDocumento", NumeroDocumento, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarEmpleado", parameters).Tables[0].Rows[0];
                EEmpleado be = new EEmpleado
                {
                    ID = Convert.ToInt32(row[0]),
                    Cargo = Convert.ToInt32(row[1]),
                    TipoDocumento = row[2].ToString(),
                    NumeroDocumento = row[3].ToString(),
                    Nombre = row[4].ToString(),
                    Apellido = row[5].ToString(),
                    FechaNacimiento = Convert.ToDateTime(row[6]),
                    Pais = row[7].ToString(),
                    Ciudad = row[8].ToString(),
                    Direccion = row[9].ToString(),
                    Email = row[10].ToString(),
                    Telefono = row[11].ToString(),
                    Estado = Convert.ToInt32(row[12])
                };
                return be;
            }
            catch
            {
                EEmpleado be = new EEmpleado();
                return be;
            }
        }

        public List<EEmpleado> Buscar(string KeyWoard)
        {
            List<EEmpleado> List = new List<EEmpleado>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@KeyWoard", KeyWoard, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_BuscarEmpleado", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EEmpleado be = new EEmpleado
                    {
                        ID = Convert.ToInt32(row[0]),
                        Cargo = Convert.ToInt32(row[1]),
                        TipoDocumento = row[2].ToString(),
                        NumeroDocumento = row[3].ToString(),
                        Nombre = row[4].ToString(),
                        Apellido = row[5].ToString(),
                        FechaNacimiento = Convert.ToDateTime(row[6]),
                        Pais = row[7].ToString(),
                        Ciudad = row[8].ToString(),
                        Direccion = row[9].ToString(),
                        Email = row[10].ToString(),
                        Telefono = row[11].ToString(),
                        Estado = Convert.ToInt32(row[12])
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

        public bool VerificarNumeroDocumento(string NumeroDocumento)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@NumeroDocumento", NumeroDocumento, SqlDbType.VarChar);
                DataRow data = Conexion.ExecuteProcedureD("USP_S_VerificarNumeroDocumentoEmpleado", parameters).Tables[0].Rows[0];
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

        public DataRow ObtenerInformacion(string NumeroDocumento)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@NumeroDocumento", NumeroDocumento, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_ObtenerInformacionEmpleado", parameters).Tables[0].Rows[0];
                return row;
            }
            catch
            {
                DataRow row = null;
                return row;
            }
        }

        public bool ModificarxUsuario(EEmpleado obj)
        {
            SQLParameter[] parameters = new SQLParameter[9];
            parameters[0] = new SQLParameter("@NumeroDocumento", obj.NumeroDocumento, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Apellido", obj.Apellido, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@FechaNacimiento", obj.FechaNacimiento, SqlDbType.Date);
            parameters[4] = new SQLParameter("@Pais", obj.Pais, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[6] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[7] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[8] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarEmpleadoUsuario", parameters);
            return Response;
        }

        public int ObtenerID(string NumeroDocumento)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@NumeroDocumento", NumeroDocumento, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_ObtenerIDEmpleado", parameters).Tables[0].Rows[0];
                return Convert.ToInt32(row[0]);
            }
            catch
            {
                return 0;
            }
        }
    }
}
