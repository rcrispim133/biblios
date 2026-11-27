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

        Func<string[], string> ConstraintName { get; }

        Func<string[], string> IndexDatabaseName { get; }

        Func<string[], string> ForeignKeyColumnName { get; }

        Func<string[], string> TextColumnName { get; }

        Func<string[], string> DateColumnName { get; }

        Func<string[], string> RawColumnName { get; }

        Func<string[], string> DescColumnName { get; }

        Func<string[], string> IdentityDatabaseName { get; }

        Func<string[], string> NameColumnName { get; }

        Func<string[], string> IdentityColumnName { get; }

        Func<string[], string> LogicColumnName { get; }

        Func<string[], string> NumberColumnName { get; }

        int BaseOrder { get; }

    }
}
