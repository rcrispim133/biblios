using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantAcronym<TEntity> : ConstantText<TEntity>, IConstantAcronym<TEntity> 
        where TEntity : class, IEntityAcronym<TEntity>, new()
    {
        #region Acronym

        public int DefaultMaxAcronym => ResourceBase.DefaultMaxAcronym.ParseFromResource();

        #endregion
    }
}
