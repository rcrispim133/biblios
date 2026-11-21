namespace Br.Bibliography.Model.Entities.Base.Interfaces
{
    public interface IEntityAcronymDesc<TEntity> : IEntityAcronym<TEntity>, IEntityDesc<TEntity> where TEntity : class, IEntityAcronymDesc<TEntity>
    {
    }
}
