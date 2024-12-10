using Domain.Models;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class StudentParentService : IStudentParent
{
    private readonly DapperContext.DapperContext context;

    public StudentParentService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteStudentParent(int id)
    {
        try
        {
            string cmd = "DELETE from StudentParent  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public bool UpdateStudentParent(StudentParent studentParent)
    {
        try
        {
            string cmd =
                "UPDATE StudentParent SET Student_id=@Student_id,Parent_id=@Parent_id,Relationship=@Relationship";
            int updated = context.Connection.Execute(cmd, studentParent);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public bool InsertStudentParent(StudentParent studentParent)
    {
        try
        {
            string cmd =
                "INSERT INTO StudentParent (capacity,room_type,description,created_at,updated_at) values (@capacity,@room_type,@description,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, studentParent);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public List<StudentParent> GetStudentParent()
    {
        try
        {
            string cmd = "Select * from StudentParent";
            List<StudentParent> result = context.Connection.Query<StudentParent>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public StudentParent GetStudentParentById(int id)
    {
        try
        {
            string cmd = "Select * from StudentParent where id = @id";
            StudentParent result = context.Connection.QuerySingleOrDefault<StudentParent>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }
}