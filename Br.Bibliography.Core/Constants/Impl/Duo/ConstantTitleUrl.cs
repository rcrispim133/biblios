using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantTitleUrl : ConstantBase<EntityTitleUrl>, IConstantTitleUrl
    {
        private ConstantTitleUrl() { }

        public static IConstantTitleUrl Factory() => new ConstantTitleUrl();
    }
}
