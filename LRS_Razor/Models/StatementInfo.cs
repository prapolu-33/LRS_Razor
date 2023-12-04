using System;
using System.ComponentModel.DataAnnotations;

namespace LRS_Razor.Models
{
    public class StatementInfo
    {
        [Key]
        public Guid? Uuid { get; set; }

        public string? Name { get; set; }

        public string? Verb { get; set; }

        public string? Object { get; set; }

        public string? TimeStamp { get; set; }
    }
}


