using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Core.Models
{
    internal class Todo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter a Due Date")]
        public DateTime? DueDate { get; set; }
        [Required(ErrorMessage = "Please Select a Category")]
        [ForeignKey(nameof(Category))]
        public string CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required(ErrorMessage = "Please Select a Status")]
        [ForeignKey(nameof(Status))]
        public string StatusId { get; set; }

        public Status? Status { get; set; }
        //public bool Overdue => StatusId == "ongoing" && DueDate < DateTime.Today;

    }
}
