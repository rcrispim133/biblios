namespace Br.Bibliography.Model.Entities.Base.Interfaces
{
    public interface IEntityLine<TEntity> : IEntityText<TEntity> where TEntity : class, IEntityLine<TEntity>
    {
        string? LineMark { get; }

        uint? LineOrder { get; }
    }
}
