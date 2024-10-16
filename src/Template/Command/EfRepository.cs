using Core.Domain.Repository;
using Core.Domain;
using Core.Domain.Domain;
using Template.Command.Database;
using Core.CommandAndQueryHandler.Repository;
namespace Template.Command
{
    public class EfRepository<T> : BaseRepository<T, DataBaseContext>, IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        public EfRepository(DataBaseContext context) : base(context) { }
    }
}
