namespace Br.Bibliography.Util.Fluent.Base
{
    public interface IFluent
    {
        static abstract string TableNameFromParams(params string[] array);

        static abstract string PrimaryKeyConstraintFromParams(params string[] array);

        static abstract string PrimaryKeyIndexFromParams(params string[] array);

        static abstract string KeyColumnNameFromParams(params string[] array);

        static abstract string TextColumnNameFromParams(params string[] array);

        static abstract string ForeignKeyConstraintNameFromParams(params string[] array);
                
        static abstract string IndexDatabaseNameFromParams(params string[] array);

        static abstract string ForeignKeyColumnNameFromParams(params string[] array);

        static abstract string AcronymColumnNameFromParams(params string[] array);

        static abstract string DateTimeColumnNameFromParams(params string[] array);

        static abstract string RawColumnNameFromParams(params string[] array);

        static abstract string DescColumnNameFromParams(params string[] array);

        static abstract string IdentityDatabaseNameFromParams(params string[] array);

        static abstract string IdentityColumnNameFromParams(params string[] array);

        static abstract string NameColumnNameFromParams(params string[] array);

        static abstract string LogicalColumnNameFromParams(params string[] array);

        static abstract string NumberColumnNameFromParams(params string[] array);
    }
}
