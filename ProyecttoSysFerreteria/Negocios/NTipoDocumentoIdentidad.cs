using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyecttoSysFerreteria.Entidad;
using ProyecttoSysFerreteria.Negocios;
namespace ProyecttoSysFerreteria.Negocios
{
    public class NTipoDocumentoIdentidad
    {
        public List<ETipoDocumentoIdentidad> Listar()
        {
            List<ETipoDocumentoIdentidad> List = new List<ETipoDocumentoIdentidad>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarTipoDocumentoIdentidad").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                ETipoDocumentoIdentidad be = new ETipoDocumentoIdentidad
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
                foreach (ETipoDocumentoIdentidad item in Listar())
                {
                    Lista.Add(item.Codigo, item.Descripcion);
                }
                return Lista;
            }
            return Lista;
        }
    }
}
