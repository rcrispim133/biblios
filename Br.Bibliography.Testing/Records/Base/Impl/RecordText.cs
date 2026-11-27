using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Util.Helpers.Impl;
using Br.Bibliography.Util.Helpers.String;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Records.Base.Impl
{
    public abstract class RecordText<TEntity, TPacket> : RecordBase<TEntity, TPacket> where TPacket : IPacketText<TEntity> where TEntity : EntityText<TEntity>, new()
    {
        public TEntity? EntityTextNull => new() { Key = HelperMath.DEFAULT_KEY, Text = HelperText.STRING_NULL };

        public TEntity? EntityTextEmpty => new() { Key = HelperMath.DEFAULT_KEY, Text = HelperText.STRING_EMPTY };

        public TEntity? EntityTextWhitespace => new() { Key = HelperMath.DEFAULT_KEY, Text = HelperText.STRING_WHITESPACE };

        public TEntity? EntityTextRandom => new() { Key = HelperMath.DEFAULT_KEY, Text = Path.GetRandomFileName() };
    }
}
