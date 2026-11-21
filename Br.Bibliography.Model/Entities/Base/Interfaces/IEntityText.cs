namespace Br.Bibliography.Model.Entities.Base.Interfaces
{
    public interface IEntityText<TEntity> : IEntityBase<TEntity> where TEntity : class, IEntityText<TEntity>
    {
        string? Text { get; set; }
    }
}
