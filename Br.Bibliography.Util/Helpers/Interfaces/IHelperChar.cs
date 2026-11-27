using Br.Bibliography.Util.Helpers.Base;

namespace Br.Bibliography.Util.Helpers.Interfaces
{
    public interface IHelperChar : IHelper
    {
        static abstract char SEPARATOR { get; }

        static abstract char EMPTY { get; }
    }
}
