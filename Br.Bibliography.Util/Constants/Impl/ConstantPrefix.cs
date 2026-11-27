using Br.Bibliography.Util.Constants.Interfaces;
using Br.Bibliography.Util.Resources;

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

        public string TableNamePrefix => ResourcePrefix.TableNamePrefix;

        public string PrimaryKeyPrefix => ResourcePrefix.PrimaryKeyPrefix;

        public string KeyPrefix => ResourcePrefix.KeyPrefix;

        public string IndexPrefix => ResourcePrefix.IndexPrefix;

        public string TextPrefix => ResourcePrefix.TextPrefix;

        public string AcronymPrefix => ResourcePrefix.AcronymPrefix;

        public string ForeignKeyPrefix => ResourcePrefix.ForeignKeyPrefix;

        public string DateTimePrefix => ResourcePrefix.DateTimePrefix;

        public string RawPrefix => ResourcePrefix.RawPrefix;

        public string DescPrefix => ResourcePrefix.DescPrefix;

        public string IdentityPrefix => ResourcePrefix.IdentityPrefix;

        public string NamePrefix => ResourcePrefix.NamePrefix;

        public string LogicalPrefix => ResourcePrefix.LogicalPrefix;

        public string NumberPrefix => ResourcePrefix.NumberPrefix;

        #endregion
    }
}
