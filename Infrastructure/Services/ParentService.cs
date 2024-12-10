using Domain.Models;
using Dapper;
namespace Infrastructure.Services;
using Infrastructure.Interfaces;

public class ParentService :IParent
{
    private readonly DapperContext.DapperContext context;

    public ParentService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteParent(int id)
    {
        try
        {
            string cmd = "DELETE from School  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public bool UpdateParent(Parent parent)
    {
        try
        {
            string cmd =
                "UPDATE School SET capacity=@capacity,room_type=@room_type,description=@description,created_at=@created_at,updated_at=@updated_at";
            int updated = context.Connection.Execute(cmd, parent);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public bool InsertParent(Parent parent)
    {
        try
        {
            string cmd =
                "INSERT INTO Student (capacity,room_type,description,created_at,updated_at) values (@capacity,@room_type,@description,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, parent);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public List<Parent> GetParent()
    {
        try
        {
            string cmd = "Select * from StudentParent";
            List<Parent> result = context.Connection.Query<Parent>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public Parent GetParentById(int id)
    {
        try
        {
            string cmd = "Select * from Parent where id = @id";
            Parent result = context.Connection.QuerySingleOrDefault<Parent>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }
}