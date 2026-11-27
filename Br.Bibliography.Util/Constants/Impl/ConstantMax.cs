using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantMax : IConstantMax
    {
        #region Constructor

        private ConstantMax() { }

        #endregion

        #region Factory

        public static IConstantMax Factory() => new ConstantMax();

        #endregion

        #region Constants

        public int MaxText => 144;

        public int MaxDesc => 500;

        public int MaxAcronym => 8;

        public int MaxRaw => 1024 * 1024;

        public int MaxName => 96;

        public int MaxRole => 16;

        public int MaxUsername => 24;

        public int MaxEmail => 96;

        public int MaxPassword => 32;

        public int MaxClaim => 16;

        public int MaxMark => 4;

        #endregion
    }
}
