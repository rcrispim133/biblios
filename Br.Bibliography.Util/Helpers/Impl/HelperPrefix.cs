using Br.Bibliography.Util.Helpers.Interfaces;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Util.Helpers.Impl
{
    public class HelperPrefix : IHelperPrefix
    {
        public static string TableNamePrefix => ResourcePrefix.TableNamePrefix;

        public static string PrimaryKeyPrefix => ResourcePrefix.PrimaryKeyPrefix;

        public static string KeyPrefix => ResourcePrefix.KeyPrefix;

        public static string IndexPrefix => ResourcePrefix.IndexPrefix;

        public static string TextPrefix => ResourcePrefix.TextPrefix;

        public static string AcronymPrefix => ResourcePrefix.AcronymPrefix;

        public static string ForeignKeyPrefix => ResourcePrefix.ForeignKeyPrefix;

        public static string DateTimePrefix => ResourcePrefix.DateTimePrefix;

        public static string RawPrefix => ResourcePrefix.RawPrefix;

        public static string DescPrefix => ResourcePrefix.DescPrefix;

        public static string IdentityPrefix => ResourcePrefix.IdentityPrefix;

        public static string NamePrefix => ResourcePrefix.NamePrefix;

        public static string LogicalPrefix => ResourcePrefix.LogicalPrefix;

        public static string NumberPrefix => ResourcePrefix.NumberPrefix;
    }
}
