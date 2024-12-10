namespace Domain.Models;

public class Teacher
{
    public int teacher_Id { get; set; }
    public string teacher_code { get; set; }
    public string teacher_full_name { get; set; }
    public string gender { get; set; }
    public DateTime dob { get; set; }
    public string email { get; set; }
    public bool is_active { get; set; }
    public DateTime join_date { get; set; }
    public int working_days { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}