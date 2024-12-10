using Domain.Models;
using Infrastructure.DapperContext;
using Npgsql;
using Dapper;
using Infrastructure.Interfaces;
namespace Infrastructure.Services;

public class ClassroomService : IClassroom
{
    private readonly DapperContext.DapperContext context;

    public ClassroomService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteClassroom(int id)
    {
        try
        {
            string cmd = "DELETE from Classroom  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public bool UpdateClassroom(Classroom classes)
    {
        try
        {
            string cmd =
                "UPDATE Classroom SET capacity=@capacity,room_type=@room_type,description=@description,created_at=@created_at,updated_at=@updated_at";
            int updated = context.Connection.Execute(cmd, classes);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public bool InsertClassroom(Classroom classes)
    {
        try
        {
            string cmd =
                "INSERT INTO Classroom (capacity,room_type,description,created_at,updated_at) values (@capacity,@room_type,@description,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, classes);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Classroom> GetClassroom()
    {
        try
        {
            string cmd = "Select * from Classroom";
            List<Classroom> result = context.Connection.Query<Classroom>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Classroom GetClassroomById(int id)
    {
        try
        {
            string cmd = "Select * from Classroom where id = @id";
            Classroom result = context.Connection.QuerySingleOrDefault<Classroom>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}