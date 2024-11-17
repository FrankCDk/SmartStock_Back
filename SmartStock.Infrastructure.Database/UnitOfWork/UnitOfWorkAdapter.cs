using MySql.Data.MySqlClient;
using SmartStock.Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWorkAdapter : IUnitOfWorkAdapter
    {

        private MySqlConnection _connection {  get; set; }
        private MySqlTransaction _transaction {  get; set; }
        public IUnitOfWorkRepositories Repositories { get; set; }

        public UnitOfWorkAdapter(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();

            _transaction = _connection.BeginTransaction();

            Repositories = new UnitOfWorkRepository(_connection, _transaction);

        }

        public void Dispose() // Lo usamos para liberar recursos del sistema
        {
            if(_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            if (_connection != null) 
            { 
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }

            Repositories = null;

        }

        public void SaveChanges() // Lo usamos para guardar cambios
        {
            _transaction.Commit();
        }

        public void Rollback() // Lo usamos para revertir los cambios
        {
            _transaction.Rollback();
        }
    }
}
