using Microsoft.Extensions.Configuration;
using SmartStock.Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWorkMySQL : IUnitOfWork
    {

        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public UnitOfWorkMySQL(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MiConexion") 
                                ?? throw new InvalidOperationException("No se encontro la cadena de conexión a la base de datos.");
        }

        public IUnitOfWorkAdapter Create()
        {
            return new UnitOfWorkAdapter(_connectionString);
        }
    }
}
