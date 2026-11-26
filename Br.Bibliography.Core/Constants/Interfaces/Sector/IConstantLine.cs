using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Constants.Interfaces.Sector
{
    public interface IConstantLine : IConstantLine<EntityLine>
    {
        #region Defaults

        public const int DefaultMarkMaxLength = 2;

        #endregion

        #region Constants

        int PropertyLineMarkMaxLength { get; }

        #endregion
    }
}
