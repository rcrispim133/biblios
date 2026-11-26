namespace Br.Bibliography.Core.Constants.Base
{
    public abstract class Constant : IConstant
    {
        #region Fluent

        public abstract string TableName { get; }

        #endregion
    }
}
