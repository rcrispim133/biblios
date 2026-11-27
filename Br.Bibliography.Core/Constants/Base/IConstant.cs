namespace Br.Bibliography.Core.Constants.Base
{
    public interface IConstant
    {
        string TableName { get; }

        string PrimaryKeyName { get; }

        string PrimaryKeyIndexName { get; }

        string PropertyKeyColumnName { get; }

        string PropertyTextColumnName { get; }

        string PropertyAcronymColumnName { get; }

        string ForeignKeyConstraintName(params string[] array);

        string IndexDatabaseName(params string[] array);

        string ForeignKeyColumnName(params string[] array);

        string DateColumnName(params string[] array);

        string RawColumnName(params string[] array);

        string DescColumnName(params string[] array);

        string IdentityDatabaseName(params string[] array);

        string NameColumnName(params string[] array);

        string IdentityColumnName(params string[] array);

        string LogicColumnName(params string[] array);

        string NumberColumnName(params string[] array);

        string TextColumnName(params string[] array);

        int BaseOrder { get; }

    }
}
