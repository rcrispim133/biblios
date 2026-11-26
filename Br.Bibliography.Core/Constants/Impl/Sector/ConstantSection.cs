using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Constants.Impl.Sector
{
    public class ConstantSection : ConstantBase<EntitySection>, IConstantSection
    {
        private ConstantSection() { }

        public static IConstantSection Factory() => new ConstantSection();
    }
}
