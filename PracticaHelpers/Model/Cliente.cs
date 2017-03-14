using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHelpers.Model
{
    class Cliente
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public Cliente()
        {

        }

        public Cliente(string name, string phone)
        {
            this.name = name;
            this.name = phone;
        }

        public DataTable Select()
        {
            DataTable result = Program.datos.SqlQuery("", new Dictionary<string, object>());
            return result;
        }

        public void Insert()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("name", this.name);
            parametros.Add("phone", this.phone);
            DataTable result = Program.datos.SqlQuery("", parametros);
            if (result.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(result.Rows[0]["id"]);
            }
        }

        public void Delete(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            Program.datos.SqlStatement("", parametros);
        }

        public void Update(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("name", this.name);
            parametros.Add("phone", this.phone);
            parametros.Add("id", id);
            Program.datos.SqlStatement("", parametros);
        }
    }
}
