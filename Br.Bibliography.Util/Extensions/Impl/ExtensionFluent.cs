using Br.Bibliography.Util.Helpers.Impl;

namespace Br.Bibliography.Util.Extensions.Impl
{
    public static class ExtensionFluent
    {
        #region Private

        static string JoinFromParams(params string[] array) => string.Join(HelperChar.SEPARATOR, array);

        static string JoinFromParams(string[] array, string prefix) => string.Join(HelperChar.SEPARATOR, array.Prepend(prefix));

        static string JoinFromParams(string[] array, string prefix, string enfix) => JoinFromParams(JoinFromParams(array, enfix), prefix);

        #endregion

        #region Entity

        public static string EntityNameFromParams(params string[] array) => JoinFromParams(array);

        #endregion

        #region Table

        public static string TableNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.TableNamePrefix);

        #endregion

        #region Primary Key

        public static string PrimaryKeyConstraintFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.PrimaryKeyPrefix, HelperPrefix.KeyPrefix);

        #endregion

        #region Index

        public static string PrimaryKeyIndexFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.IndexPrefix, HelperPrefix.KeyPrefix);

        #endregion

        #region Keys

        public static string KeyColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.KeyPrefix);

        #endregion

        #region Text

        public static string TextColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.TextPrefix);

        #endregion

        #region Acronym

        public static string AcronymColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.AcronymPrefix);

        #endregion

        #region Constraint

        public static string ForeignKeyConstraintNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.ForeignKeyPrefix);

        #endregion

        #region Index Database

        public static string IndexDatabaseNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.IndexPrefix, HelperPrefix.KeyPrefix);

        #endregion

        #region Foreign Key Column Name

        public static string ForeignKeyColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.KeyPrefix);

        #endregion
        
        #region Date

        public static string DateTimeColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.DateTimePrefix);

        #endregion

        #region Raw

        public static string RawColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.RawPrefix);

        #endregion

        #region Raw

        public static string DescColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.DescPrefix);

        #endregion

        #region Identity Index

        public static string IdentityDatabaseNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.IndexPrefix, HelperPrefix.IdentityPrefix);

        #endregion

        #region Name

        public static string NameColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.NamePrefix);

        #endregion

        #region Identity

        public static string IdentityColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.IdentityPrefix);

        #endregion

        #region Logical

        public static string LogicColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.LogicalPrefix);

        #endregion

        #region Logical

        public static string NumberColumnNameFromParams(params string[] array) => JoinFromParams(array, HelperPrefix.NumberPrefix);

        #endregion
    }
}
