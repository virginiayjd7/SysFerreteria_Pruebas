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
    public class NDetalleVenta
    {
        protected bool Response = false;
        public bool Agregar(EDetalleVenta obj)
        {
            SQLParameter[] parameters = new SQLParameter[6];
            parameters[0] = new SQLParameter("@Serie", obj.Serie, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@Numero", obj.Numero, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Producto", obj.Producto, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Precio", obj.Precio, SqlDbType.Decimal);
            parameters[4] = new SQLParameter("@Cantidad", obj.Cantidad, SqlDbType.Int);
            parameters[5] = new SQLParameter("@Importe", obj.Importe, SqlDbType.Decimal);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarDetalleVenta", parameters);
            return Response;
        }

        public List<EDetalleVenta> Seleccionar(string Serie, string Numero)
        {
            List<EDetalleVenta> List = new List<EDetalleVenta>();
            try
            {
                DataTable data = new DataTable();
                SQLParameter[] parameters = new SQLParameter[2];
                parameters[0] = new SQLParameter("@Serie", Serie, SqlDbType.VarChar);
                parameters[1] = new SQLParameter("@Numero", Numero, SqlDbType.VarChar);
                data = Conexion.ExecuteProcedureD("USP_S_SeleccionarDetalleVenta", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    EDetalleVenta be = new EDetalleVenta
                    {
                        ID = Convert.ToInt32(row[0]),
                        Serie = row[1].ToString(),
                        Numero = row[2].ToString(),
                        Producto = row[3].ToString(),
                        Precio = Convert.ToDouble(row[4]),
                        Cantidad = Convert.ToInt32(row[5]),
                        Importe = Convert.ToDouble(row[6])
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
                data = Conexion.ExecuteProcedureD("USP_S_SeleccionarDetalleVentaInfo", parameters).Tables[0];
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
