using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantPrefix : IConstantPrefix
    {
        #region Constructor

        private ConstantPrefix() { }

        #endregion

        #region Factory

        public static IConstantPrefix Factory() => new ConstantPrefix();

        #endregion

        #region Constants

        public string TableNamePrefix => "tbl";

        public string PrimaryKeyPrefix => "pk";

        public string KeyPrefix => "key";

        public string IndexPrefix => "idx";

        public string TextPrefix => "txt";

        public string AcronymPrefix => "acr";

        public string ForeignKeyPrefix => "fk";

        public string DateTimePrefix => "dt";

        public string RawPrefix => "raw";

        public string DescPrefix => "desc";

        public string IdentityPrefix => "id";

        public string NamePrefix => "nm";

        public string LogicalPrefix => "bit";

        public string NumberPrefix => "num";

        #endregion
    }
}
