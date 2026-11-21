namespace Br.Bibliography.Model.Entities.Base.Interfaces
{
    public interface IEntityAcronym<TEntity> : IEntityText<TEntity> where TEntity : class, IEntityAcronym<TEntity>
    {
        string? Acronym { get; }
    }
}
