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
    public class NTipoComprobante
    {
        public List<ETipoComprobante> Listar()
        {
            List<ETipoComprobante> List = new List<ETipoComprobante>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarTipoComprobante").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                ETipoComprobante be = new ETipoComprobante
                {
                    Codigo = row[0].ToString(),
                    Descripcion = row[1].ToString()
                };
                List.Add(be);
            }
            return List;
        }
        public Dictionary<string, string> CuadroCombinado()
        {
            Dictionary<string, string> Lista = new Dictionary<string, string>();
            if (Listar().Count > 0)
            {
                foreach (ETipoComprobante item in Listar())
                {
                    Lista.Add(item.Codigo, item.Descripcion);
                }
                return Lista;
            }
            return Lista;
        }
        public Dictionary<string, string> CuadroCombinadoFB()
        {
            Dictionary<string, string> Lista = new Dictionary<string, string>();
            if (Listar().Count > 0)
            {
                foreach (ETipoComprobante item in Listar())
                {
                    if (item.Codigo.Equals("01") || item.Codigo.Equals("03"))
                    {
                        Lista.Add(item.Codigo, item.Descripcion);
                    }
                }
                return Lista;
            }
            return Lista;
        }


    }
}
