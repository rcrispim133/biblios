using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Records.Base.Impl
{
    public abstract class RecordBase<TEntity, TPacket> : Record where TPacket : IPacketBase<TEntity> where TEntity : EntityBase<TEntity>, new()
    {
        public abstract TEntity? EntityBaseDefault { get; }

        public TEntity? EntityBaseNull => null;

        public TEntity? EntityBaseZeroKey => new() { Key = Constant.Math.Zero };

        public TEntity? EntityBaseMinKey => new() { Key = int.MinValue };

        public TEntity? EntityBaseMaxKey => new() { Key = int.MaxValue };

        public TEntity? EntityBaseRandomKey => new() { Key = new Random().Next() };
    }
}
