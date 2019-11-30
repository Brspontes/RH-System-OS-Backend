using Brspontes_RH_System_DomainCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes_RH_System_Domain.CandidateContext
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string CEP { get; set; }
        public string PublicArea { get; set; }
        public string district { get; set; }
        public Guid CandidateId { get; set; }
    }
}
