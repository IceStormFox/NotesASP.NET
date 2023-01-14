using Notes1.Core.IRepositories;

namespace Notes1.Core.Configuration
{
    public interface IUnitOfWork
    {
        INoteRepository Note { get; }
        void Save();
    }
}