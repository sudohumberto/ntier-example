
namespace NTierExample.Dll.Entities
{
    public class Log
    {
        public int Pk { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
        public DateTime? Date { get; set; }
        public string Value { get; set; } = null!;
    }
}
