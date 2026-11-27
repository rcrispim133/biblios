using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantMath : IConstantMath
    {
        private ConstantMath() { }

        public static IConstantMath Factory() => new ConstantMath();

        public int Zero => 0;
    }
}
