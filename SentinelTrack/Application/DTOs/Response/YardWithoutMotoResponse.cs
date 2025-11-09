namespace SentinelTrack.Application.DTOs.Response;

public class YardWithoutMotoResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public int? Capacity { get; set; }
}