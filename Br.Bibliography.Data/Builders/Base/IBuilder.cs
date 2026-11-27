using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Base;


namespace Br.Bibliography.Data.Builders.Base
{
    public interface IBuilder<TBuilder, TEntity> 
        where TBuilder : class, IBuilder<TBuilder, TEntity>, new() 
        where TEntity : class, IEntity
    {
        string[] EntityNameParts { get; }

        void Build(ModelBuilder builder); 
    }
}
