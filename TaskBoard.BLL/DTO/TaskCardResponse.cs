using System.ComponentModel.DataAnnotations;

namespace TaskBoard.BLL.DTO
{
    public class TaskCardResponse
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
