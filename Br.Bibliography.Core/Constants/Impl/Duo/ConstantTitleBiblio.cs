using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantTitleBiblio : ConstantBase<EntityTitleBiblio>, IConstantTitleBiblio
    {
        private ConstantTitleBiblio() { }

        public static IConstantTitleBiblio Factory() => new ConstantTitleBiblio();
    }
}
