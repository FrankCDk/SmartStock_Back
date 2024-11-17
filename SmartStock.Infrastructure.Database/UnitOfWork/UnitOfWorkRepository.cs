using MySql.Data.MySqlClient;
using SmartStock.Domain.Interfaces.Repositories;
using SmartStock.Domain.Interfaces.UnitOfWork;
using SmartStock.Infrastructure.Repositories;

namespace SmartStock.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWorkRepository(MySqlConnection mySqlConnection, MySqlTransaction mySqlTransaction) : IUnitOfWorkRepositories
    {
        public ILoginRepository LoginRepository { get; } = new LoginRepository(mySqlConnection, mySqlTransaction);
    }
}
