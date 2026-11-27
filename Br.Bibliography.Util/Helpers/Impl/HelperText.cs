using Br.Bibliography.Util.Helpers.Base;
using Br.Bibliography.Util.Helpers.Impl;
using Br.Bibliography.Util.Helpers.Interfaces;

namespace Br.Bibliography.Util.Helpers.String
{
    public class HelperText : Helper, IHelperText
    {

        public static string? STRING_NULL => null;

        public static string STRING_EMPTY => string.Empty;

        public static string STRING_WHITESPACE => new(HelperChar.EMPTY, 32); // TODO: Magic number

        public static string JoinBy(char separator, params string[] args) => string.Join(separator, args);
    }
}
