using OnionArchitecture.Core.Domain.Entities;
using OnionArchitecture.Core.Dtos.Requests;
using OnionArchitecture.Core.Dtos.Responses;
using OnionArchitecture.Core.Mappers;
using OnionArchitecture.Core.Mappers.Assignments;
using OnionArchitecture.Core.Repositories.Contracts;
using OnionArchitecture.Core.Services.Contracts;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Services
{
    public class CreateAssignmentService : ICreateAssignmentService
    {
        private readonly IAssignmentsRepository _assignmentsRepository;
        private readonly IMapper<Assignment, CreateAssignmentRequestDto> _modelMapper;
        private readonly IMapper<CreateAssignmentResponseDto, Assignment> _dtoMapper;
        public CreateAssignmentService(IAssignmentsRepository assignmentsRepository)
        {
            _assignmentsRepository = assignmentsRepository;
            _modelMapper = new CreateAssignmentRequestDtoToModelMapper();
            _dtoMapper = new CreateAssignmentResponseDtoMapper();
        }

        public async Task<CreateAssignmentResponseDto> Create(CreateAssignmentRequestDto createAssignmentRequestDto)
        {
            Assignment assignment = _modelMapper.Map(createAssignmentRequestDto);
            await _assignmentsRepository.Create(assignment);
            CreateAssignmentResponseDto response = _dtoMapper.Map(assignment);
            return response;
        }
    }
}
