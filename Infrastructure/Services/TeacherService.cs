using Domain.Models;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class TeacherService :ITeacher
{
    private readonly DapperContext.DapperContext context;

    public TeacherService()
    {
        context = new DapperContext.DapperContext();
    }
    public bool DeleteTeacher(int id)
    {
        try
        {
            string cmd = "DELETE from Teacher  where id = @id";
            int deleted = context.Connection.Execute(cmd, new { id = id });
            return deleted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public bool UpdateTeacher(Teacher teacher)
    {
        try
        {
            string cmd =
                "UPDATE Teacher SET teacher_code=@teacher_code,teacher_full_name=@teacher_full_name,gender=@gender,dob=@dob,email=@email,is_active=@is_active,Join_Date=@Join_Date,working_days=@working_days,created_at=@created_at,updated_at=@updated_at";
            int updated = context.Connection.Execute(cmd, teacher);
            return updated > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public bool InsertTeacher(Teacher teacher)
    {
        try
        {
            string cmd =
                "INSERT INTO Teacher (teacher_code,teacher_full_name,gender,dob,email,is_active,Join_Date,working_days,created_at,updated_at) values (@teacher_code,@teacher_full_name,@gender,@dob,@email,@is_active,@Join_Date,@working_days,@created_at,@updated_at)";
            int inserted = context.Connection.Execute(cmd, teacher);
            return inserted > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public List<Teacher> GetTeacher()
    {
        try
        {
            string cmd = "Select * from Teacher";
            List<Teacher> result = context.Connection.Query<Teacher>(cmd).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }

    public Teacher GetTeacherById(int id)
    {
        try
        {
            string cmd = "Select * from Teacher where id = @id";
            Teacher result = context.Connection.QuerySingleOrDefault<Teacher>(cmd, new { id = id });
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }    }
}