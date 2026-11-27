using Br.Bibliography.Util.Helpers.Base;

namespace Br.Bibliography.Util.Helpers.Interfaces
{
    public interface IHelperText : IHelper
    {
        static abstract string? STRING_NULL { get; }

        static abstract string STRING_EMPTY { get; }

        static abstract string STRING_WHITESPACE { get; }

        static abstract string JoinBy(char separator, params string[] args);
    }
}
