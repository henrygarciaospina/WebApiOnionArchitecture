using OnionArchitecture.Core.Dtos.Requests;
using OnionArchitecture.Core.Dtos.Responses;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Services.Contracts
{
    public interface ICreateAssignmentService
    {
        Task<CreateAssignmentResponseDto> Create(CreateAssignmentRequestDto createAssignmentRequestDto);
    }
}
