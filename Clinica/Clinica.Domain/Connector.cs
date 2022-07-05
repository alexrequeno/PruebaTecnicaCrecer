using System.Data.SqlClient;

namespace Clinica.DataAccessLayer
{
    public abstract class Connector
    {
        private readonly string connectionStr;
        public Connector()
        {
            connectionStr = "Data Source=DESKTOP-4DGC95R\\SQLEXPRESS;Initial Catalog=Clinica;Integrated Security=true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection();
        }
    }
}
