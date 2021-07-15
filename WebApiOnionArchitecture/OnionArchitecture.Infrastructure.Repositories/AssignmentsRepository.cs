using OnionArchitecture.Core.Domain.Entities;
using OnionArchitecture.Core.Repositories.Contracts;
using System.Threading.Tasks;

namespace OnionArchitecture.Infrastructure.Repositories
{
    public class AssignmentsRepository : IAssignmentsRepository
    {
        private readonly OnionArchitectureContext _context;
        public AssignmentsRepository(OnionArchitectureContext context) =>
            _context = context;
        public async Task Create(Assignment assignment)
        {
            await _context.AddAsync(assignment);
            await _context.SaveChangesAsync();
        }

        public async Task<Assignment> UpdateStatus(int id) 
        {

            Assignment assignment = new Assignment();
            assignment = await _context.Assignments.FindAsync(id);

            if (assignment != null) {
                assignment.Completed = true;
                await _context.SaveChangesAsync();
            }
            return assignment;
        }
    }
}
