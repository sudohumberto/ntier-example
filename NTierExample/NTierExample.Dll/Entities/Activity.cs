
using System.ComponentModel.DataAnnotations;

namespace NTierExample.Dll.Entities
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; } = null!;
    }
}
