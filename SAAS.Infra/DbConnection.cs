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
            return @"Server=dbsq0007.whservidor.com;Database=rodrigofur;User Id=rodrigofur;Password=digo310884;";
        }
        public SqlConnection getSqlConnection()
        {
            return new SqlConnection(this.GetConnectionString());
        }
    }
}
