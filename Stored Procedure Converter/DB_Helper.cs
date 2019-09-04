using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyadCapital.Base.EntitiesConverterMVCToCore
{
    class DB_Helper
    {
        public string GetNamespaceProvider(string selectedText)
        {
            string selectedProviderNameSpace = "";
            switch (selectedText)
            {
                case "SqlParameter":
                    selectedProviderNameSpace = "System.Data.SqlClient";
                    break;
                case "MySqlParameter":
                    selectedProviderNameSpace = "MySql.Data.MySqlClient";
                    break;
            }

            return selectedProviderNameSpace;
        }

        public bool CheckConnectionStringValidity(string connectionString, string provider)
        {
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
                DbConnection conn = factory.CreateConnection();
                conn.ConnectionString = GetConnectionStringBuilder(connectionString).ConnectionString;
                conn.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DbConnectionStringBuilder GetConnectionStringBuilder(string connectionString)
        {
            DbConnectionStringBuilder builder = new DbConnectionStringBuilder
            {
                ConnectionString = connectionString
            };
            return builder;
        }
    }
}
