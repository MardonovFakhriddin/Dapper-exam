namespace Domain.Models;

public class StudentParent
{
    public int Student_parent_id { get; set; }
    public int Student_id { get; set; }
    public int Parent_id { get; set; }
    public int Relationship { get; set; }
}