using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    internal class ConstantProperties : IConstantProperties
    {
        #region Constructor

        private ConstantProperties() { }

        #endregion

        #region Factory

        public static IConstantProperties Factory() => new ConstantProperties();

        #endregion

        #region Constants

        public string ACTIVATION => "activation";

        public string CONFIRMED => "confirmed";

        public string DEACTIVATION => "deactivation";

        public string EMAIL => "email";

        public string MARK => "mark";

        public string ORDER => "order";

        public string PASSWORD => "password";

        public string TRANSLATE => "translate";

        public string USERNAME => "username";

        public string VALUE => "value";

        #endregion
    }
}
