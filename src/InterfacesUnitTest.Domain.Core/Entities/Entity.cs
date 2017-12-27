using System;
using InterfacesUnitTest.Domain.Core.Interfaces.Entities;

namespace InterfacesUnitTest.Domain.Core.Entities
{
    public abstract class Entity : IEntity
    {
        protected Entity(Guid id)
        {
            if (id == Guid.Empty) id = Guid.NewGuid();
            Id = id;
        }

        public Guid Id { get; }
    }
}