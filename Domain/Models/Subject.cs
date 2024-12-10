namespace Domain.Models;

public class Subject
{
    public int Subject_Id { get; set; }
    public string Title { get; set; }
    public int School_id { get; set; }
    public int Stage { get; set; }
    public int Term { get; set; }
    public int Carry_mark { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}