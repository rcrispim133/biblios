namespace Br.Bibliography.Core.Constants.Base
{
    public abstract class Constant : IConstant
    {
        #region Constants

        const char Separator = '_';

        const string TableNamePrefix = "tbl";

        const string PrimaryKeyPrefix = "pk";

        const string ForeignKeyPrefix = "fk";

        const string KeyPrefix = "key";

        const string IndexPrefix = "idx";

        const string TextPrefix = "txt";

        #endregion

        #region Helpers

        public abstract string[] EntityNameParts { get; }

        public virtual string EntityName => string.Join(Separator, EntityNameParts);

        public virtual string TableName => $"{TableNamePrefix}{Separator}{EntityName}";

        public virtual string PrimaryKeyName => string.Join(Separator, [PrimaryKeyPrefix, KeyPrefix, EntityName]);

        public virtual string PrimaryKeyIndexName => string.Join(Separator, [IndexPrefix, KeyPrefix, EntityName]);

        public virtual string PropertyKeyColumnName => string.Join(Separator, [KeyPrefix, EntityName]);

        public virtual string PropertyTextColumnName => string.Join(Separator, [TextPrefix, EntityName]);

        public virtual Func<string[], string> ForeignKeyName => array => string.Join(Separator, array.Prepend(ForeignKeyPrefix));

        #endregion
    }
}
