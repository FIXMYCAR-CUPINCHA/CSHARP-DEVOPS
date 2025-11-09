using System.ComponentModel.DataAnnotations;

namespace SentinelTrack.Application.DTOs.Request
{
    public class YardRequest
    {
        [Required]
        public string Name { get; set; } = default!;
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Capacity { get; set; }
    }
}
