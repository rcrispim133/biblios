using Br.Bibliography.Util.Constants.Interfaces;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantDefault : IConstantDefault
    {
        private ConstantDefault() { }

        public static IConstantDefault Factory() => new ConstantDefault();

        public int Key => ResourceDefault.Key.ParseFromResource();
    }
}
