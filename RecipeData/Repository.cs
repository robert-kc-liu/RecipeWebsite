using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using Dapper;

namespace RecipeData
{
    public class Repository<T> : IRepository<T>
    {
        private readonly string _tableName;

        public Repository(string tableName)
        {
            _tableName = tableName;
        }

        public string ConnectionString
        {
            get { return ConfigurationManager.AppSettings["DatabaseConnectionString"]; }
        }

        public T FindById(int id)
        {
            T item;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                item = connection.Query<T>("SELECT * FROM " + _tableName + " WHERE RecipeId = " + id).SingleOrDefault();
            }

            return item;
        }
    }
}