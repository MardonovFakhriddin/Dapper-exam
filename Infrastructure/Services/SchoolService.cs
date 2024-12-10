using Domain.Models;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;
using Dapper;
public class SchoolService: ISchool
{
    private readonly DapperContext.DapperContext context;

    public SchoolService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteSchool(int id)
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

    public bool UpdateSchool(School school)
    {
        try
        {
            string cmd =
                "UPDATE School SET School_title=@School_title,level_count=@level_count,is_active=@is_active,created_at=@created_at,updated_at=@updated_at";
            int updated = context.Connection.Execute(cmd, school);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }       }

    public bool InsertSchool(School school)
    {
        try
        {
            string cmd =
                "INSERT INTO School (School_title,level_count,is_active,created_at,updated_at) values (@School_title,@level_count,@is_active,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, school);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }       
    }

    public List<School> GetSchool()
    {
        try
        {
            string cmd = "Select * from School";
            List<School> result = context.Connection.Query<School>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }        }

    public School GetSchoolById(int id)
    {
        try
        {
            string cmd = "Select * from School where id = @id";
            School result = context.Connection.QuerySingleOrDefault<School>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }
}