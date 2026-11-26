using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Constants.Impl.Biblio
{
    public class ConstantImage : ConstantRaw<EntityImage>, IConstantImage
    {
        #region Constructor

        private ConstantImage() { }

        #endregion

        #region Factory

        public static IConstantImage Factory() => new ConstantImage();

        #endregion

        #region Fluent

        public override string TableName => "tbl_image";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantImage.DefaultMaxText;

        #endregion
    }
}
