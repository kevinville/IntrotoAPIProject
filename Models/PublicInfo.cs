using System.ComponentModel.DataAnnotations;

namespace WorkerSalaryAPI.Models
{
    public class PublicInfo
    {
        [Key]
        public int PersonId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int? WorkerId { get; set; }
    }
}
