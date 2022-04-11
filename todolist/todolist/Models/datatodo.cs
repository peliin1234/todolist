using System;
using System.ComponentModel.DataAnnotations;

namespace todolist.Models
{
    public class datatodo
    {
        [Key]
        public int Id { get; set; }
        public string Donote { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Datetime { get; set; }
    }
}
