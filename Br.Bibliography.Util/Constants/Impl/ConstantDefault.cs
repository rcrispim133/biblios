using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantDefault : IConstantDefault
    {
        #region Constructor

        private ConstantDefault() { }

        #endregion

        #region Factory

        public static IConstantDefault Factory() => new ConstantDefault();

        #endregion

        #region Constants

        public int Key => 0;

        public string DatabaseName => "fluent.db";

        #endregion
    }
}
