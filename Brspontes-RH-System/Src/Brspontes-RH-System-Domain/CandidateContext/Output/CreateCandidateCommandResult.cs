using Brspontes_RH_System_Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes_RH_System_Domain.CandidateContext.Output
{
    public class CreateCandidateCommandResult : ICommandResult
    {

        public object notifications { get; set; }
    }
}
