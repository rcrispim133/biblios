using Br.Bibliography.Model.Entities.Base;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Helpers.Base;
using Br.Bibliography.Util.Helpers.Impl;
using Br.Bibliography.Util.Helpers.String;

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

        public virtual string EntityName => ExtensionFluent.EntityNameFromParams(EntityNameParts);

        public virtual string TableName => ExtensionFluent.TableNameFromParams(EntityName);

        public virtual string PrimaryKeyName => ExtensionFluent.PrimaryKeyConstraintFromParams(EntityName);

        public virtual string PrimaryKeyIndexName => ExtensionFluent.PrimaryKeyIndexFromParams(EntityName);

        public virtual string PropertyKeyColumnName => ExtensionFluent.KeyColumnNameFromParams(EntityName);

        public virtual string PropertyTextColumnName => ExtensionFluent.TextColumnNameFromParams(EntityName);

        public virtual string PropertyAcronymColumnName => ExtensionFluent.AcronymColumnNameFromParams(EntityName);

        public virtual string ForeignKeyConstraintName(params string[] array) => ExtensionFluent.ForeignKeyConstraintNameFromParams(array);

        public virtual string IndexDatabaseName(params string[] array) => ExtensionFluent.IndexDatabaseNameFromParams(array);

        public virtual string ForeignKeyColumnName(params string[] array) => ExtensionFluent.ForeignKeyColumnNameFromParams(array);

        public virtual string DateColumnName(params string[] array) => ExtensionFluent.DateTimeColumnNameFromParams(array);

        public virtual string RawColumnName(params string[] array) => ExtensionFluent.RawColumnNameFromParams(array);

        public virtual string DescColumnName(params string[] array) => ExtensionFluent.DescColumnNameFromParams(array);

        public virtual string IdentityDatabaseName(params string[] array) => ExtensionFluent.IdentityDatabaseNameFromParams(array);

        public virtual string NameColumnName(params string[] array) => ExtensionFluent.NameColumnNameFromParams(array);

        public virtual string IdentityColumnName(params string[] array) => ExtensionFluent.IdentityColumnNameFromParams(array);

        public virtual string LogicColumnName(params string[] array) => ExtensionFluent.LogicColumnNameFromParams(array);

        public virtual string NumberColumnName(params string[] array) => ExtensionFluent.LogicColumnNameFromParams(array);

        public virtual string TextColumnName(params string[] array) => ExtensionFluent.TextColumnNameFromParams(array);

        public virtual int BaseOrder => HelperMath.ZERO;

        #endregion
    }
}
