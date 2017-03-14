using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaHelpers.Utils;

namespace PracticaHelpers
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlHelper sql = new SqlHelper();
            String[] campos = new String[] { "campo1","campo2","campo3"};
            sql.InsertSql("profesor",campos);

        }
    }
}
