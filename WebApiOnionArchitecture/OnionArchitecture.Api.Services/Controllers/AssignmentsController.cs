using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.Dtos.Requests;
using OnionArchitecture.Core.Dtos.Responses;
using OnionArchitecture.Core.Mappers.Assignments;
using OnionArchitecture.Core.Services.Contracts;
using OnionArchitecture.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace OnionArchitecture.Api.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        private readonly ICreateAssignmentService _createAssignmentService;
        private readonly IUpdateAssignmentService _updateAssignmentService;

        private readonly OnionArchitectureContext _context;

        public AssignmentsController(ICreateAssignmentService createAssignmentService, IUpdateAssignmentService updateAssignmentService,
            OnionArchitectureContext context
            )
        {
            _createAssignmentService = createAssignmentService;
            _updateAssignmentService = updateAssignmentService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAssignmentRequestDto createAssignmentRequestDto)
        {
            CreateAssignmentResponseDto response = await _createAssignmentService.Create(createAssignmentRequestDto);
            return Ok(response);
        }


        [HttpPut("{id:int}")]

        public async Task<IActionResult> UpdateStatus(int id, UpdateAssignmentResponseDto response)
        {
            var assigment  = await _context.Assignments.FirstOrDefaultAsync(a => a.Id == id);
        
            if (assigment == null)
            {
                return NotFound($"Id {id} assignment does not exist");
            }

            response = await _updateAssignmentService.UpdateStatus(id);
            return NoContent();
        }

    }
}
