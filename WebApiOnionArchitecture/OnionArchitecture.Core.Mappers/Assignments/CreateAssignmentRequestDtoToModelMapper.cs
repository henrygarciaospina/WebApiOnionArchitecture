using OnionArchitecture.Core.Domain.Entities;
using OnionArchitecture.Core.Dtos.Requests;

namespace OnionArchitecture.Core.Mappers.Assignments
{
    public class CreateAssignmentRequestDtoToModelMapper : IMapper<Assignment, CreateAssignmentRequestDto>
    {
        public Assignment Map(CreateAssignmentRequestDto source)
        {
            var assignment = new Assignment { Name = source.Name, Description = source.Description };
            return assignment;
        }
    }
}
