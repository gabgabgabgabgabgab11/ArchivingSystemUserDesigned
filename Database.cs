using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivingSystemUserDesigned
{
    internal class Database
    {
        private string connectionString = "Server=localhost;Database=academic_archive;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
