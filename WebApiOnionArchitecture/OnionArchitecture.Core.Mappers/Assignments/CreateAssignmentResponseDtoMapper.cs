using OnionArchitecture.Core.Domain.Entities;
using OnionArchitecture.Core.Dtos.Responses;

namespace OnionArchitecture.Core.Mappers.Assignments
{
    public class CreateAssignmentResponseDtoMapper : IMapper<CreateAssignmentResponseDto, Assignment>
    {
        public CreateAssignmentResponseDto Map(Assignment source)
        {
            var createAssignmentResponseDto = new CreateAssignmentResponseDto
            {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
            };
            return createAssignmentResponseDto;
        }
    }
}
