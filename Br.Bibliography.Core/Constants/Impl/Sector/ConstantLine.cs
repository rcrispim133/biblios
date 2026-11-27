using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Util.Extensions;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Core.Constants.Impl.Sector
{
    public class ConstantLine : ConstantLine<EntityLine>, IConstantLine
    {
        #region Constructor

        private ConstantLine() { }

        #endregion

        #region Factory

        public static IConstantLine Factory() => new ConstantLine();

        #endregion

        #region Fluent

        public int DefaultMarkMaxLength => ResourceBase.DefaultMarkMaxLength.Parse();

        public override string[] EntityNameParts => [ StaticEntityNames.LINE ];

        #endregion
    }
}
