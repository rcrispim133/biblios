using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Base
{
    public interface IConstant
    {
        #region Math

        static abstract IConstantMath Math { get; }

        #endregion

        #region Defaults

        static abstract IConstantDefault Default { get; }

        #endregion

        #region Max

        static abstract IConstantMax Max { get; }

        #endregion

        #region Entities

        static abstract IConstantBase Base { get; }

        #endregion

        #region Properties

        static abstract IConstantProperties Properties { get; }

        #endregion

        #region String

        static abstract IConstantString String { get; }

        #endregion

        #region Prefix

        static abstract IConstantPrefix Prefix { get; }

        #endregion

        #region Char

        static abstract IConstantChar Char { get; }

        #endregion
    }
}
