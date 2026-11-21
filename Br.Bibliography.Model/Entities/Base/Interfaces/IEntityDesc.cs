namespace Br.Bibliography.Model.Entities.Base.Interfaces
{
    public interface IEntityDesc<TEntity> : IEntityBase<TEntity> where TEntity : class, IEntityDesc<TEntity>
    {
        string? Desc { get; set; }
    }
}
