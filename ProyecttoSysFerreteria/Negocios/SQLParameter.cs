using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProyecttoSysFerreteria.Negocios
{
    public class SQLParameter
    {
        public string Name;
        public object Value;
        public SqlDbType Type;
        public SQLParameter(string name, object value, SqlDbType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }

    }
}
