using System.Data;
using DesignPatternsCourse2.Cap1;

namespace DesignPatternsCourse2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = $"select * from tabela";
        }
    }
}