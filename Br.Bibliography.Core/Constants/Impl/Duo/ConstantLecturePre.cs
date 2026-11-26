using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantLecturePre : ConstantBase<EntityLecturePre>, IConstantLecturePre
    {
        #region Constructor

        private ConstantLecturePre() { }

        #endregion

        #region Factory

        public static IConstantLecturePre Factory() => new ConstantLecturePre();

        #endregion

        #region Fluent

        public override string TableName => "tbl_lecture_pre";

        #endregion
    }
}
