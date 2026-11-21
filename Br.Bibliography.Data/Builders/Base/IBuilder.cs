using Br.Bibliography.Model.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Base
{
    public interface IBuilder<TBuilder, TEntity> where TBuilder : class, IBuilder<TBuilder, TEntity>, new() where TEntity : class, IEntity
    {
        void Build(ModelBuilder builder); 
    }
}
