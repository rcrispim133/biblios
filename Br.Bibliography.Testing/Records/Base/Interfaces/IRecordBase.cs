using Br.Bibliography.Model.Entities.Base.Impl;

namespace Br.Bibliography.Testing.Records.Base.Interfaces
{
    public interface IRecordBase<TEntity> : IRecord where TEntity : EntityBase<TEntity>, new()
    {
        TEntity? EntityBaseDefault { get; }

        TEntity? EntityBaseNull { get; }

        TEntity? EntityBaseZeroKey { get; }

        TEntity? EntityBaseMinKey { get; }

        TEntity? EntityBaseMaxKey { get; }

        TEntity? EntityBaseRandomKey { get; }
    }
}
