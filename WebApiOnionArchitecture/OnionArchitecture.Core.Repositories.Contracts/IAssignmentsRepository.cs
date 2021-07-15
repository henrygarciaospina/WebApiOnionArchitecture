using OnionArchitecture.Core.Domain.Entities;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Repositories.Contracts
{
    public interface IAssignmentsRepository
    {
        Task Create(Assignment assignment);

        Task<Assignment> UpdateStatus(int id);
    }
}
