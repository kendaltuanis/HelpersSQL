using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHelpers.Utils
{
   
        class SqlHelper
        {
            public string InsertSql(string table, string[] fields)
            {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO ").Append(table).Append(" VALUES(");
            foreach (string field in fields)
            {
                sql.Append(field).Append(","); 
            }


                return "";
            }

            public string UpdateSql(string table, string[] fields)
            {
                return "";
            }

            public string DeleteSql(string table, string[] fields)
            {
                return "";
            }

            public string SelectSql(string table, string[] fields)
            {
                return "";
            }
        }

    }

