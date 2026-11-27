using Br.Bibliography.Util.Constants.Interfaces;
using Br.Bibliography.Util.Resources;

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

        public string ACTIVATION => ResourceProperties.ACTIVATION;

        public string CONFIRMED => ResourceProperties.CONFIRMED;

        public string DEACTIVATION => ResourceProperties.DEACTIVATION;

        public string EMAIL => ResourceProperties.EMAIL;

        public string MARK => ResourceProperties.MARK;

        public string ORDER => ResourceProperties.ORDER;

        public string PASSWORD => ResourceProperties.PASSWORD;

        public string TRANSLATE => ResourceProperties.TRANSLATE;

        public string USERNAME => ResourceProperties.USERNAME;

        public string VALUE => ResourceProperties.VALUE;

        #endregion
    }
}
