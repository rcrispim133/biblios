using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Constants.Impl.Sector
{
    public class ConstantLine : ConstantLine<EntityLine>, Interfaces.Sector.IConstantLine
    {
        #region Constructor

        private ConstantLine() { }

        #endregion

        #region Factory

        public static IConstantLine Factory() => new ConstantLine();

        #endregion

        #region Fluent

        public override string TableName => "tbl_line";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantLine.DefaultMaxText;

        #endregion
    }
}
