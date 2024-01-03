using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure
{
    public class DbConnect : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DbConnect()
        {
           Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=portal;User Id=postgres;Password=123456;");
           Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
