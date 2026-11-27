using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Base
{
    public class Constant : IConstant
    {
        #region Math

        public static IConstantMath Math { get; } = ConstantMath.Factory();

        #endregion

        #region Default

        public static IConstantDefault Default => ConstantDefault.Factory();

        #endregion

        #region Max

        public static IConstantMax Max => ConstantMax.Factory();

        #endregion

        #region Base

        public static IConstantBase Base => ConstantBase.Factory();

        #endregion

        #region Properties

        public static IConstantProperties Properties => ConstantProperties.Factory();

        #endregion

        #region String

        public static IConstantString String => ConstantString.Factory();

        #endregion

        #region Prefix

        public static IConstantPrefix Prefix => ConstantPrefix.Factory();

        #endregion

        #region Char

        public static IConstantChar Char => ConstantChar.Factory();

        #endregion
    }
}
