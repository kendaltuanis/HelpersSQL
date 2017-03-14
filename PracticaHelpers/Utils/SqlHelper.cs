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
                return string.Format("INSERT INTO {0} ({1}) VALUES ({2})", table, string.Join(",", fields), string.Join(",", fields.Select(s => "@" + s)));
            
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

