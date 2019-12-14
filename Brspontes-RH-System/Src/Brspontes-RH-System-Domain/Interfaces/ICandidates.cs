using Brspontes_RH_System_Domain.CandidateContext.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes_RH_System_Domain.Interfaces
{
    public interface ICandidates
    {
        ICommandResult CreateCandidate(CreateCandidateCommand command);
    }
}
