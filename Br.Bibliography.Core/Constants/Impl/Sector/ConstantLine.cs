using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Core.Util.Static;
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

        public override string[] EntityNameParts => [ StaticEntityNames.LINE ];

        #endregion

        #region Text

        public override int ConstantMaxText => IConstantLine.DefaultMaxText;

        #endregion
    }
}
