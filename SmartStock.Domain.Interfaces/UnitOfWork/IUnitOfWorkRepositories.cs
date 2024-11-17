using SmartStock.Domain.Interfaces.Repositories;

namespace SmartStock.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWorkRepositories
    {
        ILoginRepository LoginRepository { get; }
    }
}
