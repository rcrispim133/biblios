using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantWork : ConstantText<EntityWork>, IConstantWork
    {

        #region Constructor

        private ConstantWork() { }

        #endregion

        #region Factory

        public static IConstantWork Factory() => new ConstantWork();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.WORK ];

        #endregion
    }
}
