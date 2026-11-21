using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Br.Bibliography.Data.Contexts.Base
{
    public interface IContext : IDisposable
    {
        int SaveChanges();

        DatabaseFacade Database { get; }
    }
}
