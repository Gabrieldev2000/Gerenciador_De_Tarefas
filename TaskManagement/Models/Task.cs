using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class Task
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public string UserId { get; set; } // Campo UserId para associar a tarefa ao usuário
    }
}
