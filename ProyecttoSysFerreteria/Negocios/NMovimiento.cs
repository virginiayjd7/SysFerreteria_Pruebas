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
    public class NMovimiento
    {
        protected bool Response = false;
        public bool Agregar(EMovimiento obj)
        {
            SQLParameter[] parameters = new SQLParameter[15];
            parameters[0] = new SQLParameter("@Fecha", obj.Fecha, SqlDbType.Date);
            parameters[1] = new SQLParameter("@TipoComprobante", obj.TipoComprobante, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Serie", obj.Serie, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Numero", obj.Numero, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@TipoOperacion", obj.TipoOperacion, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Producto", obj.Producto, SqlDbType.VarChar);
            parameters[6] = new SQLParameter("@CantidadEntrada", obj.CantidadEntrada, SqlDbType.Int);
            parameters[7] = new SQLParameter("@CostoUnitarioEntrada", obj.CostoUnitarioEntrada, SqlDbType.Decimal);
            parameters[8] = new SQLParameter("@CostoTotalEntrada", obj.CostoTotalEntrada, SqlDbType.Decimal);
            parameters[9] = new SQLParameter("@CantidadSalida", obj.CantidadSalida, SqlDbType.Int);
            parameters[10] = new SQLParameter("@CostoUnitarioSalida", obj.CostoUnitarioSalida, SqlDbType.Decimal);
            parameters[11] = new SQLParameter("@CostoTotalSalida", obj.CostoTotalSalida, SqlDbType.Decimal);
            parameters[12] = new SQLParameter("@CantidadFinal", obj.CantidadFinal, SqlDbType.Int);
            parameters[13] = new SQLParameter("@CostoUnitarioFinal", obj.CostoUnitarioFinal, SqlDbType.Decimal);
            parameters[14] = new SQLParameter("@CostoTotalFinal", obj.CostoTotalFinal, SqlDbType.Decimal);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarMovimiento", parameters);
            return Response;
        }

        public List<EMovimiento> Listar()
        {
            List<EMovimiento> List = new List<EMovimiento>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarMovimientos").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EMovimiento be = new EMovimiento
                    {
                        ID = Convert.ToInt32(row[0]),
                        Fecha = Convert.ToDateTime(row[1]),
                        TipoComprobante = row[2].ToString(),
                        Serie = row[3].ToString(),
                        Numero = row[4].ToString(),
                        TipoOperacion = row[5].ToString(),
                        Producto = row[6].ToString(),
                        CantidadEntrada = Convert.ToInt32(row[7]),
                        CostoUnitarioEntrada = Convert.ToDouble(row[8]),
                        CostoTotalEntrada = Convert.ToDouble(row[9]),
                        CantidadSalida = Convert.ToInt32(row[10]),
                        CostoUnitarioSalida = Convert.ToDouble(row[11]),
                        CostoTotalSalida = Convert.ToDouble(row[12]),
                        CantidadFinal = Convert.ToInt32(row[13]),
                        CostoUnitarioFinal = Convert.ToDouble(row[14]),
                        CostoTotalFinal = Convert.ToDouble(row[15])
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

        public List<EMovimiento> ListarxProducto(string Producto)
        {
            List<EMovimiento> List = new List<EMovimiento>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Producto", Producto, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_SeleccionarMovimientoProducto", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EMovimiento be = new EMovimiento
                    {
                        ID = Convert.ToInt32(row[0]),
                        Fecha = Convert.ToDateTime(row[1]),
                        TipoComprobante = row[2].ToString(),
                        Serie = row[3].ToString(),
                        Numero = row[4].ToString(),
                        TipoOperacion = row[5].ToString(),
                        Producto = row[6].ToString(),
                        CantidadEntrada = Convert.ToInt32(row[7]),
                        CostoUnitarioEntrada = Convert.ToDouble(row[8]),
                        CostoTotalEntrada = Convert.ToDouble(row[9]),
                        CantidadSalida = Convert.ToInt32(row[10]),
                        CostoUnitarioSalida = Convert.ToDouble(row[11]),
                        CostoTotalSalida = Convert.ToDouble(row[12]),
                        CantidadFinal = Convert.ToInt32(row[13]),
                        CostoUnitarioFinal = Convert.ToDouble(row[14]),
                        CostoTotalFinal = Convert.ToDouble(row[15])
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

        public List<EMovimiento> ListarxFechasxProducto(DateTime FirstDate, DateTime LastDate, string Producto)
        {
            List<EMovimiento> List = new List<EMovimiento>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[3];
                parameters[0] = new SQLParameter("@FirstDate", FirstDate, SqlDbType.Date);
                parameters[1] = new SQLParameter("@LastDate", LastDate, SqlDbType.Date);
                parameters[2] = new SQLParameter("@Producto", Producto, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_SeleccionarMovimientoFechasProducto", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EMovimiento be = new EMovimiento
                    {
                        ID = Convert.ToInt32(row[0]),
                        Fecha = Convert.ToDateTime(row[1]),
                        TipoComprobante = row[2].ToString(),
                        Serie = row[3].ToString(),
                        Numero = row[4].ToString(),
                        TipoOperacion = row[5].ToString(),
                        Producto = row[6].ToString(),
                        CantidadEntrada = Convert.ToInt32(row[7]),
                        CostoUnitarioEntrada = Convert.ToDouble(row[8]),
                        CostoTotalEntrada = Convert.ToDouble(row[9]),
                        CantidadSalida = Convert.ToInt32(row[10]),
                        CostoUnitarioSalida = Convert.ToDouble(row[11]),
                        CostoTotalSalida = Convert.ToDouble(row[12]),
                        CantidadFinal = Convert.ToInt32(row[13]),
                        CostoUnitarioFinal = Convert.ToDouble(row[14]),
                        CostoTotalFinal = Convert.ToDouble(row[15])
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

        public List<EMovimiento> ListarxPeriodoxProducto(string Periodo, string Producto)
        {
            List<EMovimiento> List = new List<EMovimiento>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Periodo", Periodo, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Producto", Producto, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_SeleccionarMovimientoxPeriodoProducto", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EMovimiento be = new EMovimiento
                    {
                        ID = Convert.ToInt32(row[0]),
                        Fecha = Convert.ToDateTime(row[1]),
                        TipoComprobante = row[2].ToString(),
                        Serie = row[3].ToString(),
                        Numero = row[4].ToString(),
                        TipoOperacion = row[5].ToString(),
                        Producto = row[6].ToString(),
                        CantidadEntrada = Convert.ToInt32(row[7]),
                        CostoUnitarioEntrada = Convert.ToDouble(row[8]),
                        CostoTotalEntrada = Convert.ToDouble(row[9]),
                        CantidadSalida = Convert.ToInt32(row[10]),
                        CostoUnitarioSalida = Convert.ToDouble(row[11]),
                        CostoTotalSalida = Convert.ToDouble(row[12]),
                        CantidadFinal = Convert.ToInt32(row[13]),
                        CostoUnitarioFinal = Convert.ToDouble(row[14]),
                        CostoTotalFinal = Convert.ToDouble(row[15])
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

        public EMovimiento SeleccionarUltimoMovimientoProducto(string Producto)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Producto", Producto, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarUltimoMovimientoProducto", parameters).Tables[0].Rows[0];
                EMovimiento be = new EMovimiento
                {
                    ID = Convert.ToInt32(row[0]),
                    Fecha = Convert.ToDateTime(row[1]),
                    TipoComprobante = row[2].ToString(),
                    Serie = row[3].ToString(),
                    Numero = row[4].ToString(),
                    TipoOperacion = row[5].ToString(),
                    Producto = row[6].ToString(),
                    CantidadEntrada = Convert.ToInt32(row[7]),
                    CostoUnitarioEntrada = Convert.ToDouble(row[8]),
                    CostoTotalEntrada = Convert.ToDouble(row[9]),
                    CantidadSalida = Convert.ToInt32(row[10]),
                    CostoUnitarioSalida = Convert.ToDouble(row[11]),
                    CostoTotalSalida = Convert.ToDouble(row[12]),
                    CantidadFinal = Convert.ToInt32(row[13]),
                    CostoUnitarioFinal = Convert.ToDouble(row[14]),
                    CostoTotalFinal = Convert.ToDouble(row[15])
                };
                return be;
            }
            catch
            {
                EMovimiento be = new EMovimiento();
                return be;
            }
        }

        public EMovimiento SeleccionarUltimoMovimientoProductoFinal(string Producto)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Producto", Producto, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarUltimoMovimientoProductoFinal", parameters).Tables[0].Rows[0];
                EMovimiento be = new EMovimiento
                {
                    CantidadFinal = Convert.ToInt32(row[0]),
                    CostoUnitarioFinal = Convert.ToDouble(row[1]),
                    CostoTotalFinal = Convert.ToDouble(row[2])
                };
                return be;
            }
            catch
            {
                EMovimiento be = new EMovimiento();
                return be;
            }
        }
    }
}
