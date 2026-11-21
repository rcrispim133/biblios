namespace Br.Bibliography.Model.Entities.Base.Interfaces
{
    public interface IEntityRaw<TEntity> : IEntityText<TEntity> where TEntity : class, IEntityRaw<TEntity>
    {
        byte[]? Raw { get; }
    }
}
