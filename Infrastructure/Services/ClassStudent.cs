using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class ClassStudent : IClassStudent
{
    private readonly DapperContext.DapperContext context;

    public ClassStudent()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteClassStudent(int id)
    {
        try
        {
            string cmd = "DELETE from ClassStudent  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public bool UpdateClassStudent(Domain.Models.ClassStudent classStudent)
    {
        try
        {
            string cmd =
                "UPDATE ClassStudent SET class_id=@class_id,student_id=@student_id";
            int updated = context.Connection.Execute(cmd, classStudent);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public bool InsertClassStudent(Domain.Models.ClassStudent classStudent)
    {
        try
        {
            string cmd =
                "INSERT INTO ClassStudent (class_id,student_id) values (@class_id,@student_id)";
            int inserted = context.Connection.Execute(cmd, classStudent);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<ClassStudent> GetClassStudent()
    {
        try
        {
            string cmd = "Select * from ClassStudent";
            List<ClassStudent> result = context.Connection.Query<ClassStudent>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public ClassStudent? GetClassStudentById(int id)
    {
        try
        {
            string cmd = "Select * from ClassStudent where id = @id";
            ClassStudent resultStudent = context.Connection.QuerySingleOrDefault<ClassStudent>(cmd, new { id = id });
            return resultStudent;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}