using Br.Bibliography.Model.Entities.Base;
using Br.Bibliography.Util.Helpers.Base;

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

        const string DateTimePrefix = "dt";

        const string RawPrefix = "raw";

        const string AcronymPrefix = "acronym";

        const string DescPrefix = "desc";

        const string IdentityPrefix = "id";

        const string NamePrefix = "nm";

        const string LogicPrefix = "bit";

        const string NumberPrefix = "int";

        #endregion

        #region Helpers

        public abstract string[] EntityNameParts { get; }

        public virtual string EntityName => string.Join(Separator, EntityNameParts);

        public virtual string TableName => $"{TableNamePrefix}{Separator}{EntityName}";

        public virtual string PrimaryKeyName => string.Join(Separator, [PrimaryKeyPrefix, KeyPrefix, EntityName]);

        public virtual string PrimaryKeyIndexName => string.Join(Separator, [IndexPrefix, KeyPrefix, EntityName]);

        public virtual string PropertyKeyColumnName => string.Join(Separator, [KeyPrefix, EntityName]);

        public virtual string PropertyTextColumnName => string.Join(Separator, [TextPrefix, EntityName]);

        public virtual string PropertyAcronymColumnName => string.Join(Separator, [AcronymPrefix, EntityName]);

        public virtual Func<string[], string> ConstraintName => array => string.Join(Separator, array.Prepend(ForeignKeyPrefix));

        public virtual Func<string[], string> IndexDatabaseName => array => string.Join(Separator, array.Prepend(KeyPrefix).Prepend(IndexPrefix));

        public virtual Func<string[], string> ForeignKeyColumnName => array => string.Join(Separator, array.Prepend(KeyPrefix));

        public virtual Func<string[], string> TextColumnName => array => string.Join(Separator, array.Prepend(TextPrefix));

        public virtual Func<string[], string> DateColumnName => array => string.Join(Separator, array.Prepend(DateTimePrefix));

        public virtual Func<string[], string> RawColumnName => array => string.Join(Separator, array.Prepend(RawPrefix));

        public virtual Func<string[], string> DescColumnName => array => string.Join(Separator, array.Prepend(DescPrefix));

        public virtual Func<string[], string> IdentityDatabaseName => array => string.Join(Separator, array.Prepend(IdentityPrefix).Prepend(IndexPrefix));

        public virtual Func<string[], string> NameColumnName => array => string.Join(Separator, array.Prepend(NamePrefix));

        public virtual Func<string[], string> IdentityColumnName => array => string.Join(Separator, array.Prepend(IdentityPrefix));

        public virtual Func<string[], string> LogicColumnName => array => string.Join(Separator, array.Prepend(LogicPrefix));

        public virtual Func<string[], string> NumberColumnName => array => string.Join(Separator, array.Prepend(NumberPrefix));

        public virtual int BaseOrder => Helper.ZERO;

        #endregion
    }
}
