namespace Br.Bibliography.Core.Exceptions
{
    public class ExceptionControllerHandleCreate<TEntity> : Exception
    {
        public TEntity? Entity { get; init; }

        protected ExceptionControllerHandleCreate(TEntity? entity)
        {
            Entity = entity;
        }

        public static ExceptionControllerHandleCreate<TEntity> Throw(TEntity? entity) => new ExceptionControllerHandleCreate<TEntity>(entity);
    }
}
