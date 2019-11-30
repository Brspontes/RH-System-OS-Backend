using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes_RH_System_DomainCore.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
