using Br.Bibliography.Util.Constants.Interfaces;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantMath : IConstantMath
    {
        private ConstantMath() { }

        public static IConstantMath Factory() => new ConstantMath();

        public int Zero => ResourceMath.Zero.ParseFromResource();
    }
}
