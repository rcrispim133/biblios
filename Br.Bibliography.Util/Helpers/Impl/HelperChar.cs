using Br.Bibliography.Util.Helpers.Base;
using Br.Bibliography.Util.Helpers.Interfaces;

namespace Br.Bibliography.Util.Helpers.Impl
{
    public class HelperChar : Helper, IHelperChar
    {
        public static char SEPARATOR => '_';

        public static char EMPTY => ' ';
    }
}
