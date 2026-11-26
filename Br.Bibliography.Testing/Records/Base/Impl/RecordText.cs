using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Records.Base.Impl
{
    public abstract class RecordText<TEntity, TPacket> : RecordBase<TEntity, TPacket> where TPacket : IPacketText<TEntity> where TEntity : EntityText<TEntity>, new()
    {
        public TEntity? EntityTextNull => new() { Key = 1, Text = null };

        public TEntity? EntityTextEmpty => new() { Key = 1, Text = string.Empty };

        public TEntity? EntityTextWhitespace => new() { Key = 1, Text = new (' ', 20) };

        public TEntity? EntityTextRandom => new() { Key = 1, Text = Path.GetRandomFileName() };
    }
}
