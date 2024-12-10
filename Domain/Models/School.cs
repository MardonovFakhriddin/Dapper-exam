namespace Domain.Models;

public class School
{
    public int School_id { get; set; }
    public string School_title { get; set; }
    public string level_count { get; set; }
    public bool is_active { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}