using System;
using InterfacesUnitTest.Domain.Core.Entities;

namespace UnitTestProject.Domain.Core.Tests.DomainFake.Entities
{
    public class Fake1 : Entity
    {
        public Fake1(Guid id) : 
            base(id)
        {
        }
    }
}