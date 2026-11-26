using Br.Bibliography.Model.Entities.Base.Impl;

namespace Br.Bibliography.Testing.Records.Base.Interfaces
{
    public interface IRecordText<TEntity> : IRecordBase<TEntity> where TEntity : EntityText<TEntity>, new()
    {
        TEntity? EntityTextNull { get; }

        TEntity? EntityTextEmpty { get; }

        TEntity? EntityTextWhitespace { get; }

        TEntity? EntityTextRandom { get; }
    }
}
