namespace Br.Bibliography.Core.Constants.Base
{
    public abstract class Constant : IConstant
    {
        #region Constants

        public const char Separator = '_';

        public const string TableNamePrefix = "tbl";

        public const string PrimaryKeyPrefix = "pk";

        public const string ForeignKeyPrefix = "fk";

        public const string KeyPrefix = "key";

        public const string IndexPrefix = "idx";

        public const string TextPrefix = "txt";

        #endregion

        #region Helpers

        public abstract string[] EntityNameParts { get; }

        public virtual string EntityName => string.Join(Separator, EntityNameParts);

        public virtual string TableName => $"{TableNamePrefix}{Separator}{EntityName}";

        public virtual string PrimaryKeyName => string.Join(Separator, [PrimaryKeyPrefix, KeyPrefix, EntityName]);

        public virtual string PrimaryKeyIndexName => string.Join(Separator, [IndexPrefix, KeyPrefix, EntityName]);

        public virtual string PropertyKeyName => string.Join(Separator, [KeyPrefix, EntityName]);

        public virtual string PropertyTextName => string.Join(Separator, [TextPrefix, EntityName]);

        public virtual Func<string[], string> ForeignKeyName => array => string.Join(Separator, array);

        #endregion
    }
}
