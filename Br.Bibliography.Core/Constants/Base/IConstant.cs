namespace Br.Bibliography.Core.Constants.Base
{
    public interface IConstant
    {

        string TableName { get; }

        string PrimaryKeyName { get; }

        string PrimaryKeyIndexName { get; }

        string PropertyKeyColumnName { get; }

        string PropertyTextColumnName { get; }

        Func<string[], string> ForeignKeyName { get; }
    }
}
