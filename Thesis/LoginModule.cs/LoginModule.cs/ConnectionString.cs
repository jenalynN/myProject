using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginModule.cs
{
    public static class ConnectionString
    {
        //     Connection from Web Server
        //public const string myConnection = "Server=bigdata.clgps38zjdow.us-east-2.rds.amazonaws.com;" +
        //    "Database=db_poshconceptstorefinal;" +
        //    "Uid=root;" +
        //    "Password=abcefg13!#;" +
        //    "Convert Zero Datetime=True;" +
        //    "Allow Zero Datetime=True;"
        //  + "Connection Timeout=30000";

        // Connection from XAMPP
        public const string myConnection = "Server=localhost;" +
            "Database=db_poshconceptstorefinal;" +
            "Uid=root;" +
            "Password=;" +
            "Convert Zero Datetime=True;" +
            "Allow Zero Datetime=True;"
          + "Connection Timeout=30000";


    }
}
