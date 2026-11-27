using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantString : IConstantString
    {
        #region Constructor

        private ConstantString() { }

        #endregion

        #region Factory

        public static IConstantString Factory() => new ConstantString();

        #endregion

        #region Constants

        public string? NULL => null;

        public string EMPTY => string.Empty;

        public string WHITESPACE => new string(Constant.Char.EMPTY, Constant.Max.MaxText);

        #endregion
    }
}
