using Domain.Models;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class SubjectService : ISubject
{
    private readonly DapperContext.DapperContext context;

    public SubjectService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteSubject(int id)
    {
        try
        {
            string cmd = "DELETE from Subject  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }     }

    public bool UpdateSubject(Subject subject)
    {
        try
        {
            string cmd =
                "UPDATE Subject SET Title=@Title,School_id=@School_id,Stage=@Stage,Term=@Term,Carry_mark=@Carry_mark,created_at=@created_at,updated_at=@updated_at";
            int updated = context.Connection.Execute(cmd, subject);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }     }

    public bool InsertSubject(Subject subject)
    {
        try
        {
            string cmd =
                "INSERT INTO Subject (Title,School_id,Stage,Term,Carry_mark,created_at,updated_at) values (@School_id,@Stage,@Term,@Carry_mark,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, subject);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }     }

    public List<Subject> GetSubject()
    {
        try
        {
            string cmd = "Select * from Subject";
            List<Subject> result = context.Connection.Query<Subject>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }

    public Subject GetSubjectById(int id)
    {
        try
        {
            string cmd = "Select * from Subject where id = @id";
            Subject result = context.Connection.QuerySingleOrDefault<Subject>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }
}