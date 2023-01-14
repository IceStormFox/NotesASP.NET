using Notes1.Core.Configuration;
using Notes1.Core.IRepositories;
using Notes1.Core.Repositories;

namespace Notes1.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public INoteRepository Note { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            Note = new NoteRepository(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}