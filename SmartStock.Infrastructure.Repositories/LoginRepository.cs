using MySql.Data.MySqlClient;
using SmartStock.Domain.Interfaces.Repositories;

namespace SmartStock.Infrastructure.Repositories
{
    public class LoginRepository : Repository, ILoginRepository
    {

        public LoginRepository(MySqlConnection mySqlConnection, MySqlTransaction mySqlTransaction)
        {
            this.mySqlConnection = mySqlConnection;
            this.mySqlTransaction = mySqlTransaction;
        }

    }
}
