namespace TaskBoard.Core.Models
{
    public class TaskCard
    {
        public const int MAX_TITLE_LENGTH = 250;

        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}

