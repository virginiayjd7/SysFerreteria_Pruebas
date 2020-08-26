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
    public class NDetalleCompra
    {
        protected bool Response = false;
        public bool Agregar(EDetalleCompra obj)
        {
            SQLParameter[] parameters = new SQLParameter[6];
            parameters[0] = new SQLParameter("@Serie", obj.Serie, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@Numero", obj.Numero, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Producto", obj.Producto, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@PrecioUnitario", obj.PrecioUnitario, SqlDbType.Decimal);
            parameters[4] = new SQLParameter("@Cantidad", obj.Cantidad, SqlDbType.Int);
            parameters[5] = new SQLParameter("@PrecioTotal", obj.PrecioTotal, SqlDbType.Decimal);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarDetalleCompra", parameters);
            return Response;
        }

        public List<EDetalleCompra> Seleccionar(string Serie, string Numero)
        {
            List<EDetalleCompra> List = new List<EDetalleCompra>();
            try
            {
                DataTable data = new DataTable();
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Serie", Serie, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Numero", Numero, SqlDbType.VarChar);
                data = Conexion.ExecuteProcedureD("USP_S_SeleccionarDetalleCompra", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EDetalleCompra be = new EDetalleCompra
                    {
                        ID = Convert.ToInt32(row[0]),
                        Serie = row[1].ToString(),
                        Numero = row[2].ToString(),
                        Producto = row[3].ToString(),
                        PrecioUnitario = Convert.ToDouble(row[4]),
                        Cantidad = Convert.ToInt32(row[5]),
                        PrecioTotal = Convert.ToDouble(row[6])
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

        public DataTable SeleccionarDetalle(string Serie, string Numero)
        {
            DataTable data = new DataTable();
            try
            {
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Serie", Serie, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Numero", Numero, SqlDbType.VarChar);
                data = Conexion.ExecuteProcedureD("USP_S_SeleccionarDetalleCompraInfo", parameters).Tables[0];
                return data;
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
                return data;
            }
        }

    }
}
