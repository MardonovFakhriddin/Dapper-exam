namespace Domain.Models;

public class Classroom
{
    public int classroom_id { get; set; }
    public int capacity { get; set; }
    public int room_type { get; set; }
    public string description { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}