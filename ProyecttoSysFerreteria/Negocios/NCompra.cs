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
    public class NCompra
    {
        protected bool Response = false;
        public bool Agregar(ECompra obj)
        {
            SQLParameter[] parameters = new SQLParameter[10];
            parameters[0] = new SQLParameter("@Proveedor", obj.Proveedor, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Empleado", obj.Empleado, SqlDbType.Int);
            parameters[2] = new SQLParameter("@TipoComprobante", obj.TipoComprobante, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Serie", obj.Serie, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Numero", obj.Numero, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Fecha", obj.Fecha, SqlDbType.Date);
            parameters[6] = new SQLParameter("@SubTotal", obj.SubTotal, SqlDbType.Decimal);
            parameters[7] = new SQLParameter("@Igv", obj.Igv, SqlDbType.Decimal);
            parameters[8] = new SQLParameter("@Total", obj.Total, SqlDbType.Decimal);
            parameters[9] = new SQLParameter("@Estado", obj.Estado, SqlDbType.Int);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarCompra", parameters);
            return Response;
        }

        public List<ECompra> Listar()
        {
            List<ECompra> List = new List<ECompra>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarCompras").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    ECompra be = new ECompra
                    {
                        ID = Convert.ToInt32(row[0]),
                        Proveedor = Convert.ToInt32(row[1]),
                        Empleado = Convert.ToInt32(row[2]),
                        TipoComprobante = row[3].ToString(),
                        Serie = row[4].ToString(),
                        Numero = row[5].ToString(),
                        Fecha = Convert.ToDateTime(row[6]),
                        SubTotal = Convert.ToDouble(row[7]),
                        Igv = Convert.ToDouble(row[8]),
                        Total = Convert.ToDouble(row[9]),
                        Estado = Convert.ToInt32(row[10])
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
        public ECompra Seleccionar(string Serie, string Numero)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Serie", Serie, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Numero", Numero, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarCompra", parameters).Tables[0].Rows[0];
                ECompra be = new ECompra
                {
                    ID = Convert.ToInt32(row[0]),
                    Proveedor = Convert.ToInt32(row[1]),
                    Empleado = Convert.ToInt32(row[2]),
                    TipoComprobante = row[3].ToString(),
                    Serie = row[4].ToString(),
                    Numero = row[5].ToString(),
                    Fecha = Convert.ToDateTime(row[6]),
                    SubTotal = Convert.ToDouble(row[7]),
                    Igv = Convert.ToDouble(row[8]),
                    Total = Convert.ToDouble(row[9]),
                    Estado = Convert.ToInt32(row[10])
                };
                return be;
            }
            catch
            {
                ECompra be = new ECompra();
                return be;
            }
        }

        public List<ECompra> BuscarxFecha(DateTime FirstDate, DateTime LastDate)
        {
            List<ECompra> List = new List<ECompra>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@FirstDate", FirstDate, SqlDbType.Date);
                parameters[1] = new SQLParameter("@LastDate", LastDate, SqlDbType.Date);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarCompraxFecha", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    ECompra be = new ECompra
                    {
                        ID = Convert.ToInt32(row[0]),
                        Proveedor = Convert.ToInt32(row[1]),
                        Empleado = Convert.ToInt32(row[2]),
                        TipoComprobante = row[3].ToString(),
                        Serie = row[4].ToString(),
                        Numero = row[5].ToString(),
                        Fecha = Convert.ToDateTime(row[6]),
                        SubTotal = Convert.ToDouble(row[7]),
                        Igv = Convert.ToDouble(row[8]),
                        Total = Convert.ToDouble(row[9]),
                        Estado = Convert.ToInt32(row[10])
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

        public DataRow SeleccionarCompra(string Serie, string Numero)
        {
            DataRow row = null;
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Serie", Serie, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Numero", Numero, SqlDbType.VarChar);
                row = Conexion.ExecuteProcedureD("USP_S_SeleccionarCompraInfo", parameters).Tables[0].Rows[0];
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
