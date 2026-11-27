using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Util.Helpers.Interfaces
{
    public interface IHelperPrefix
    {
        static abstract string TableNamePrefix { get; }

        static abstract string PrimaryKeyPrefix { get; }

        static abstract string KeyPrefix { get; }

        static abstract string IndexPrefix { get; }

        static abstract string TextPrefix { get; }

        static abstract string AcronymPrefix { get; }

        static abstract string ForeignKeyPrefix { get; }

        static abstract string DateTimePrefix { get; }

        static abstract string RawPrefix { get; }

        static abstract string DescPrefix { get; }

        static abstract string IdentityPrefix { get; }

        static abstract string NamePrefix { get; }

        static abstract string LogicalPrefix { get; }

        static abstract string NumberPrefix { get; }
    }
}
