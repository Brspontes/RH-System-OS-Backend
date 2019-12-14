using Brspontes_RH_System_Domain.CandidateContext;

namespace Brspontes_RH_System_Domain.Interfaces.Repositories
{
    public interface ICandidateRepository
    {
        ICommandResult CreateCandidate(Candidate command);
    }
}
