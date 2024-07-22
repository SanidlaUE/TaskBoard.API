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
        public async Task<IActionResult> CreateTaskCard(TaskCardRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _taskCardService.Create(request);
            return Ok();
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateTaskCard(Guid id, TaskCardRequest request)
        {
            var taskId = await _taskCardService.Update(id, request);
            return Ok(taskId);
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteTaskCard(Guid id)
        {
            return Ok(await _taskCardService.Delete(id));
        }
    }   
}
