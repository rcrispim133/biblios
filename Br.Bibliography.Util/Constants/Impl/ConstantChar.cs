using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantChar : IConstantChar
    {
        #region Constructor

        private ConstantChar() { }

        #endregion

        #region Factory

        public static IConstantChar Factory() => new ConstantChar();

        #endregion

        #region Constants

        public char SEPARATOR => '_';

        public char EMPTY => ' ';

        #endregion
    }
}
