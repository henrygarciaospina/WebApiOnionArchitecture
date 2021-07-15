using OnionArchitecture.Core.Mappers.Assignments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Services.Contracts
{
    public interface IUpdateAssignmentService
    {
        Task<UpdateAssignmentResponseDto> UpdateStatus(int id);
    }
}
