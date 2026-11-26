using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Records.Base.Impl
{
    public abstract class RecordBase<TEntity, TPacket> : Record where TPacket : IPacketBase<TEntity> where TEntity : EntityBase<TEntity>, new()
    {
        public abstract TEntity? EntityBaseDefault { get; }

        public TEntity? EntityBaseNull => null;

        public TEntity? EntityBaseZeroKey => new() { Key = 0 };

        public TEntity? EntityBaseMinKey => new() { Key = uint.MinValue };

        public TEntity? EntityBaseMaxKey => new() { Key = uint.MaxValue };

        public TEntity? EntityBaseRandomKey => new() { Key = (uint)new Random().Next() };
    }
}
