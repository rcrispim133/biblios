using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Records.Base.Impl
{
    public abstract class RecordText<TEntity, TPacket> : RecordBase<TEntity, TPacket> where TPacket : IPacketText<TEntity> where TEntity : EntityText<TEntity>, new()
    {
        public TEntity? EntityTextNull => new() { Key = Constant.Default.Key, Text = Constant.String.NULL };

        public TEntity? EntityTextEmpty => new() { Key = Constant.Default.Key, Text = Constant.String.EMPTY };

        public TEntity? EntityTextWhitespace => new() { Key = Constant.Default.Key, Text = Constant.String.WHITESPACE };

        public TEntity? EntityTextRandom => new() { Key = Constant.Default.Key, Text = Path.GetRandomFileName() };
    }
}
