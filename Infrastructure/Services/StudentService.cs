using Domain.Models;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class StudentService : IStudent
{
    private readonly DapperContext.DapperContext context;

    public StudentService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteStudent(int id)
    {
        try
        {
            string cmd = "DELETE from Student  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public bool UpdateStudent(Student student)
    {
        try
        {
            string cmd =
                "UPDATE Student SET Student_Code=@Student_Code,Student_Full_Name=@Student_Full_Name,Gender=@Gender,Dob=@Dob,Email=@Email,Phone=@Phone,School_Id=@School_Id,Stage=@Stage,Section=@Section,Is_Active=@Is_Active,Join_Date=@Join_Date,@created_at=@created_at,updated_at=@updated_at";
            int updated = context.Connection.Execute(cmd, student);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    
    }

    public bool InsertStudent(Student student)
    {
        try
        {
            string cmd =
                "INSERT INTO Student (Student_Code,Student_Full_Name,Gender,Dob,Email,Phone,School_Id,Stage,Section,Is_Active,Join_Date,created_at,updated_at) values (@Student_Code,@Student_Full_Name,@Gender,@Dob,@Email,@Phone,@School_Id,@Stage,@Section,@Is_Active,@Join_Date,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, student);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }

    public List<Student> GetStudent()
    {
        try
        {
            string cmd = "Select * from Student";
            List<Student> result = context.Connection.Query<Student>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }

    public Student GetStudentById(int id)
    {
        try
        {
            string cmd = "Select * from Student where id = @id";
            Student result = context.Connection.QuerySingleOrDefault<Student>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }
}