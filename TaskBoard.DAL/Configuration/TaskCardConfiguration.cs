using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TaskBoard.DAL.Entities;
using TaskBoard.Core.Models;

namespace TaskBoard.DAL.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<TaskCardEntity>
    {
        public void Configure(EntityTypeBuilder<TaskCardEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Title)
                .HasMaxLength(TaskCard.MAX_TITLE_LENGTH)
                .IsRequired();

            builder.Property(b => b.Description)
                .IsRequired();

            builder.Property(b => b.DueDate)
                .IsRequired();

            builder.Property(b => b.Priority)
                .IsRequired();

            builder.Property(b=> b.Status)
                .IsRequired();
        }
    }
}
