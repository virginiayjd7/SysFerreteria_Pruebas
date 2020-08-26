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
    public class NVenta
    {
        protected bool Response = false;
        public bool Agregar(EVenta obj)
        {
            SQLParameter[] parameters = new SQLParameter[11];
            parameters[0] = new SQLParameter("@Cliente", obj.Cliente, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Empleado", obj.Empleado, SqlDbType.Int);
            parameters[2] = new SQLParameter("@TipoComprobante", obj.TipoComprobante, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Serie", obj.Serie, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Numero", obj.Numero, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Fecha", obj.Fecha, SqlDbType.Date);
            parameters[6] = new SQLParameter("@Hora", DBNull.Value, SqlDbType.Time);
            parameters[7] = new SQLParameter("@SubTotal", obj.SubTotal, SqlDbType.Decimal);
            parameters[8] = new SQLParameter("@Igv", obj.Igv, SqlDbType.Decimal);
            parameters[9] = new SQLParameter("@Total", obj.Total, SqlDbType.Decimal);
            parameters[10] = new SQLParameter("@Estado", obj.Estado, SqlDbType.Int);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarVenta", parameters);
            return Response;
        }
        public List<EVenta> Listar()
        {
            List<EVenta> List = new List<EVenta>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarVentas").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EVenta be = new EVenta
                    {
                        ID = Convert.ToInt32(row[0]),
                        Cliente = Convert.ToInt32(row[1]),
                        Empleado = Convert.ToInt32(row[2]),
                        TipoComprobante = row[3].ToString(),
                        Serie = row[4].ToString(),
                        Numero = row[5].ToString(),
                        Fecha = Convert.ToDateTime(row[6]),
                        //Hora = Convert.ToDateTime(row[7]),
                        SubTotal = Convert.ToDouble(row[8]),
                        Igv = Convert.ToDouble(row[9]),
                        Total = Convert.ToDouble(row[10]),
                        Estado = Convert.ToInt32(row[11])
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

        public DataRow ObtenerSerieCorrelativo(string tipo)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Tipo", tipo, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SerieCorrelativo", parameters).Tables[0].Rows[0];
                return row;
            }
            catch
            {
                DataRow row = null;
                return row;
            }
        }

        public List<EVenta> BuscarxFecha(DateTime FirstDate, DateTime LastDate)
        {
            List<EVenta> List = new List<EVenta>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@FirstDate", FirstDate, SqlDbType.Date);
                parameters[1] = new SQLParameter("@LastDate", LastDate, SqlDbType.Date);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarVentaxFecha", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EVenta be = new EVenta
                    {
                        ID = Convert.ToInt32(row[0]),
                        Cliente = Convert.ToInt32(row[1]),
                        Empleado = Convert.ToInt32(row[2]),
                        TipoComprobante = row[3].ToString(),
                        Serie = row[4].ToString(),
                        Numero = row[5].ToString(),
                        Fecha = Convert.ToDateTime(row[6]),
                        //Hora = Convert.ToDateTime(row[7]),
                        SubTotal = Convert.ToDouble(row[8]),
                        Igv = Convert.ToDouble(row[9]),
                        Total = Convert.ToDouble(row[10]),
                        Estado = Convert.ToInt32(row[11])
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

        public DataRow SeleccionarVenta(string Serie, string Numero)
        {
            DataRow row = null;
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Serie", Serie, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Numero", Numero, SqlDbType.VarChar);
                row = Conexion.ExecuteProcedureD("USP_S_SeleccionarVentaInfo", parameters).Tables[0].Rows[0];
                return row;
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
                return row;
            }
        }
    }
}
