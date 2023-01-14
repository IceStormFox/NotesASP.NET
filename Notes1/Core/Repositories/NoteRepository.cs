using Notes1.Core.IRepositories;
using Notes1.Data;
using Notes1.Models;

namespace Notes1.Core.Repositories
{
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        public NoteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}