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
        private readonly ITaskCardService<TaskCardDto> _taskCardService;

        public TaskCardController(ITaskCardService<TaskCardDto> taskCardService)
        {
            _taskCardService = taskCardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTaskCards()
        {
            var cards = await _taskCardService.GetAllTaskCards();
            return Ok(cards);
        }
    }
}
