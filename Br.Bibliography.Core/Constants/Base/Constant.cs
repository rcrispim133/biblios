namespace Br.Bibliography.Core.Constants.Base
{
    public abstract class Constant : IConstant
    {
        #region Constants

        public const char Separator = '_';

        public const string TableNamePrefix = "tbl";

        #endregion

        #region Helpers

        public abstract string[] EntityNameParts { get; }

        public virtual string EntityName => string.Join(Separator, EntityNameParts);

        public virtual string TableName => $"{TableNamePrefix}{Separator}{EntityName}";

        #endregion
    }
}
