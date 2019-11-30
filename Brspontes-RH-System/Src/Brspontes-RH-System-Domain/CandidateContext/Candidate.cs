using Brspontes_RH_System_DomainCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes_RH_System_Domain.CandidateContext
{
    public class Candidate : Entity
    {
        public string FullName { get; set; }
        public string Curriculum { get; set; }
        public string Email { get; set; }
        public string Observation { get; set; }
        public string Document { get; set; }
        public Address Address { get; set; }
    }
}
