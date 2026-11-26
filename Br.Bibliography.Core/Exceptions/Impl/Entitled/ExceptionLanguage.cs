using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using System;
using System.Collections.Generic;
using System.Text;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionLanguage : ExceptionText<EntityLanguage>, IExceptionLanguage
    {
        public override EntityLanguage? Entity { get; init; }

        public ExceptionLanguage(EntityLanguage? entity) : base(entity) { }
    }
}
