﻿
using System.ComponentModel.DataAnnotations;

namespace NTierExample.Dll.Entities
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
        public DateTime? Date { get; set; }
        public string Value { get; set; } = null!;
    }
}
