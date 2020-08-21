using System.Data.SqlClient;
namespace SAAS.Infra
{
    public class DbConnection
    {
        private static Ambiente ambiente = 0;
        public DbConnection()
        {

        }
        public string GetConnectionString()
        {
            return @"Server=;Database=;User Id=;Password=;";
        }
        public SqlConnection getSqlConnection()
        {
            return new SqlConnection(this.GetConnectionString());
        }
    }
}
