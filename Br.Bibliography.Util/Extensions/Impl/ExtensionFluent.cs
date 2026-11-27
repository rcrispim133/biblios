using Br.Bibliography.Util.Constants.Base;

namespace Br.Bibliography.Util.Extensions.Impl
{
    public static class ExtensionFluent
    {
        #region Private

        static string JoinFromParams(params string[] array) => ExtensionString.FromParams(Constant.Char.SEPARATOR, array);

        static string JoinFromParams(string[] array, string prefix) => ExtensionString.FromParams(Constant.Char.SEPARATOR, array, prefix);

        static string JoinFromParams(string[] array, string prefix, string enfix) => ExtensionString.FromParams(Constant.Char.SEPARATOR, array, prefix, enfix);

        #endregion

        #region Entity

        public static string EntityNameFromParams(params string[] array) => JoinFromParams(array);

        #endregion

        #region Table

        public static string TableNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.TableNamePrefix);

        #endregion

        #region Primary Key

        public static string PrimaryKeyConstraintFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.PrimaryKeyPrefix, Constant.Prefix.KeyPrefix);

        #endregion

        #region Index

        public static string PrimaryKeyIndexFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.IndexPrefix, Constant.Prefix.KeyPrefix);

        #endregion

        #region Keys

        public static string KeyColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.KeyPrefix);

        #endregion

        #region Text

        public static string TextColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.TextPrefix);

        #endregion

        #region Acronym

        public static string AcronymColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.AcronymPrefix);

        #endregion

        #region Constraint

        public static string ForeignKeyConstraintNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.ForeignKeyPrefix);

        #endregion

        #region Index Database

        public static string IndexDatabaseNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.IndexPrefix, Constant.Prefix.KeyPrefix);

        #endregion

        #region Foreign Key Column Name

        public static string ForeignKeyColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.KeyPrefix);

        #endregion
        
        #region Date

        public static string DateTimeColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.DateTimePrefix);

        #endregion

        #region Raw

        public static string RawColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.RawPrefix);

        #endregion

        #region Desc

        public static string DescColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.DescPrefix);

        #endregion

        #region Identity Index

        public static string IdentityDatabaseNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.IndexPrefix, Constant.Prefix.IdentityPrefix);

        #endregion

        #region Name

        public static string NameColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.NamePrefix);

        #endregion

        #region Identity

        public static string IdentityColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.IdentityPrefix);

        #endregion

        #region Logical

        public static string LogicalColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.LogicalPrefix);

        #endregion

        #region Number

        public static string NumberColumnNameFromParams(params string[] array) => JoinFromParams(array, Constant.Prefix.NumberPrefix);

        #endregion
    }
}
