namespace Domain.Models;

public class Class
{
    public int class_id { get; set; }
    public string class_name { get; set; }
    public int subject_id { get; set; }
    public int teacher_id { get; set; }
    public int classroom_id { get; set; }
    public string Section { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}