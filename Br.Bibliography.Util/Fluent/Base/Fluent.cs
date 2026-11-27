using Br.Bibliography.Util.Extensions.Impl;

namespace Br.Bibliography.Util.Fluent.Base
{
    public abstract class Fluent : IFluent
    {
        public static string TableNameFromParams(params string[] array) => ExtensionFluent.TableNameFromParams(array);

        public static string PrimaryKeyConstraintFromParams(params string[] array) => ExtensionFluent.PrimaryKeyConstraintFromParams(array);

        public static string PrimaryKeyIndexFromParams(params string[] array) => ExtensionFluent.PrimaryKeyIndexFromParams(array);

        public static string KeyColumnNameFromParams(params string[] array) => ExtensionFluent.KeyColumnNameFromParams(array);

        public static string TextColumnNameFromParams(params string[] array) => ExtensionFluent.TextColumnNameFromParams(array);

        public static string ForeignKeyConstraintNameFromParams(params string[] array) => ExtensionFluent.ForeignKeyConstraintNameFromParams(array);

        public static string IndexDatabaseNameFromParams(params string[] array) => ExtensionFluent.IndexDatabaseNameFromParams(array);

        public static string ForeignKeyColumnNameFromParams(params string[] array) => ExtensionFluent.ForeignKeyColumnNameFromParams(array);

        public static string AcronymColumnNameFromParams(params string[] array) => ExtensionFluent.AcronymColumnNameFromParams(array);

        public static string DateTimeColumnNameFromParams(params string[] array) => ExtensionFluent.DateTimeColumnNameFromParams(array);

        public static string RawColumnNameFromParams(params string[] array) => ExtensionFluent.RawColumnNameFromParams(array);

        public static string DescColumnNameFromParams(params string[] array) => ExtensionFluent.DescColumnNameFromParams(array);

        public static string IdentityDatabaseNameFromParams(params string[] array) => ExtensionFluent.IdentityDatabaseNameFromParams(array);

        public static string IdentityColumnNameFromParams(params string[] array) => ExtensionFluent.IdentityColumnNameFromParams(array);

        public static string NameColumnNameFromParams(params string[] array) => ExtensionFluent.NameColumnNameFromParams(array);

        public static string LogicalColumnNameFromParams(params string[] array) => ExtensionFluent.LogicalColumnNameFromParams(array);

        public static string NumberColumnNameFromParams(params string[] array) => ExtensionFluent.NumberColumnNameFromParams(array);
    }
}
