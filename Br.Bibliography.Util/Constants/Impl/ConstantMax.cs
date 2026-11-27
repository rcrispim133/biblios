using Br.Bibliography.Util.Constants.Interfaces;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantMax : IConstantMax
    {
        private ConstantMax() { }

        public static IConstantMax Factory() => new ConstantMax();

        public int MaxText => ResourceMax.Text.ParseFromResource();

        public int MaxDesc => ResourceMax.Desc.ParseFromResource();

        public int MaxAcronym => ResourceMax.Acronym.ParseFromResource();

        public int MaxRaw => ResourceMax.Raw.ParseFromResource();

        public int MaxName => ResourceMax.Name.ParseFromResource();

        public int MaxRole => ResourceMax.Role.ParseFromResource();

        public int MaxUsername => ResourceMax.Username.ParseFromResource();

        public int MaxEmail => ResourceMax.Email.ParseFromResource();

        public int MaxPassword => ResourceMax.Password.ParseFromResource();

        public int MaxClaim => ResourceMax.Claim.ParseFromResource();

        public int MaxMark => ResourceMax.Mark.ParseFromResource();
    }
}
