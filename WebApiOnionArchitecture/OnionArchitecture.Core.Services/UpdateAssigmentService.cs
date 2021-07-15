using OnionArchitecture.Core.Domain.Entities;
using OnionArchitecture.Core.Mappers;
using OnionArchitecture.Core.Mappers.Assignments;
using OnionArchitecture.Core.Repositories.Contracts;
using OnionArchitecture.Core.Services.Contracts;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Services
{
    public class UpdateAssigmentService: IUpdateAssignmentService
    {
        private readonly IAssignmentsRepository _assignmentsRepository;
        private readonly IMapper<UpdateAssignmentResponseDto, Assignment> _dtoMapper;

        public UpdateAssigmentService(IAssignmentsRepository assignmentsRepository)
        {
            _assignmentsRepository = assignmentsRepository;
            _dtoMapper = new UpdateAssignmentResponseDtoMapper();
        }
        public async Task<UpdateAssignmentResponseDto> UpdateStatus(int id) 
        {
           
            Assignment assignment = await _assignmentsRepository.UpdateStatus(id);

            UpdateAssignmentResponseDto response = _dtoMapper.Map(assignment);
            return response;
        }
    }
}
