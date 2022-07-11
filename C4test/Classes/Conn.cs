using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4test.Classes
{
    internal class Conn
    {
       // public NpgsqlConnection connection = new NpgsqlConnection(string.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", "5432", "postgres", "123", "Db"));
        public NpgsqlConnection connection = new NpgsqlConnection(string.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "postgresql-82475-0.cloudclusters.net", "12601", "user", "USER!123!x!", "Db"));
    }
}
