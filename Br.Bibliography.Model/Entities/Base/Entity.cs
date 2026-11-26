namespace Br.Bibliography.Model.Entities.Base
{
    public abstract class Entity : IEntity
    {
        public uint? Key { get; init; }
    }
}
