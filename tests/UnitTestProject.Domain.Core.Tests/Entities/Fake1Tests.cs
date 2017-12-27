using System;
using InterfacesUnitTest.Domain.Core.Interfaces.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Domain.Core.Tests.DomainFake.Entities;

namespace UnitTestProject.Domain.Core.Tests.Entities
{
    [TestClass]
    public class Fake1Tests : EntityTests
    {
        public override IEntity GetEntityInstanceParseEmptyId()
        {
            return new Fake1(Guid.Empty);
        }

        public override IEntity GetEntityInstanceParseValidId()
        {
            return new Fake1(Guid.NewGuid());
        }
    }
}