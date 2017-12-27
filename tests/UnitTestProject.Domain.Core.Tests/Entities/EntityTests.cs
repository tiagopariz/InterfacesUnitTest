using System;
using InterfacesUnitTest.Domain.Core.Interfaces.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Domain.Core.Tests.Entities
{
    [TestClass]
    public abstract class EntityTests
    {
        public abstract IEntity GetEntityInstanceParseEmptyId();
        public abstract IEntity GetEntityInstanceParseValidId();

        [TestMethod]
        public void EntityParseEmptyIdReturnValidGuid()
        {
            var entity = GetEntityInstanceParseEmptyId();
            var id = entity.Id;
            Assert.IsTrue(Guid.Empty != id);
        }

        [TestMethod]
        public void EntityParseValidIdReturnValidGuid()
        {
            var entity = GetEntityInstanceParseValidId();
            var id = entity.Id;
            Assert.IsTrue(Guid.Empty != id);
        }
    }
}