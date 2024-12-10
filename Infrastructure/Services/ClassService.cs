using Domain.Models;
using Infrastructure.DapperContext;
using Npgsql;
using Dapper;
using Infrastructure.Interfaces;
namespace Infrastructure.Services;

public class ClassService : IClass
{
    private readonly DapperContext.DapperContext context;

    public ClassService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteClass(int id)
    {
        try
        {
            string cmd = "DELETE from class  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public bool UpdateClass(Class classes)
    {
        try
        {
            string cmd =
                "UPDATE Class SET class_name=@class_name,subject_id=@subject_id,teacher_id=@teacher_id,classroom_id=@classroom_id,section=@section,created_at=@created_at,updated_at=@updated_at";
            int updated = context.Connection.Execute(cmd, classes);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public bool InsertClass(Class classes)
    {
        try
        {
            string cmd =
                "INSERT INTO Class (class_name,subject_id,teacher_id,classroom_id,section,created_at,updated_at) values (@class_name,@subject_id,@teacher_id,@classroom_id,@section,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, classes);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Class> GetClass()
    {
        try
        {
            string cmd = "Select * from Class";
            List<Class> result = context.Connection.Query<Class>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Class GetClassById(int id)
    {
        try
        {
            string cmd = "Select * from Class where id = @id";
            Class result = context.Connection.QuerySingleOrDefault<Class>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}