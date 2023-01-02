using System.Data;
using System.Data.SqlClient;

namespace DesignPatternsCourse2.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
            conexao.Open();
            return conexao;
        }
    }
}