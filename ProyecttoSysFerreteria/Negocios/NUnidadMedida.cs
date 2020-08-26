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
    public class NUnidadMedida
    {
        public List<EUnidadMedida> Listar()
        {
            List<EUnidadMedida> List = new List<EUnidadMedida>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarUnidadMedida").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                EUnidadMedida be = new EUnidadMedida
                {
                    Codigo = row[0].ToString(),
                    Descripcion = row[1].ToString(),
                    Abreviatura = row[2].ToString(),
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
                foreach (EUnidadMedida item in Listar())
                {
                    Lista.Add(item.Codigo, item.Descripcion);
                }
                return Lista;
            }
            return Lista;
        }
    }
}
