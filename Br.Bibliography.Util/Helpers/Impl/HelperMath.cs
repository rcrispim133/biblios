using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Helpers.Base;
using Br.Bibliography.Util.Helpers.Interfaces;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Util.Helpers.Impl
{
    public class HelperMath : Helper, IHelperMath
    {
        public static int ZERO => ResourceMath.ZERO.ParseFromResource();

        public static int DEFAULT_KEY => ResourceMath.DEFAULT_KEY.ParseFromResource();
    }
}
