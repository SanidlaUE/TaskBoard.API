using Microsoft.AspNetCore.Mvc;
using TaskBoard.BLL.DTO;
using TaskBoard.BLL.Services;
using TaskBoard.Core.Abstractions;

namespace TaskBoard.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskCardController : ControllerBase
    {
        private readonly ITaskCardService<TaskCardResponse, TaskCardRequest> _taskCardService;

        public TaskCardController(ITaskCardService<TaskCardResponse, TaskCardRequest> taskCardService)
        {
            _taskCardService = taskCardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTaskCards()
        {
            var cards = await _taskCardService.GetAllTaskCards();
            return Ok(cards);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTaskCard(TaskCardDto taskCardDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _taskCardService.Create(taskCardDto);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTaskCard(int id,TaskCardDto taskCardDto)
        {
            if(!ModelState.IsValid)
            {
            return BadRequest(ModelState); 
            }
            var existingTaskCard = await _taskCardService.GetById(id);
            if (existingTaskCard != null)
            {
                return NotFound();
            }
            await _taskCardService.Update(id,taskCardDto);
            return NoContent();
        }
    }
}
