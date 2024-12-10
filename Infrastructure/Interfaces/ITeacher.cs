using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ITeacher
{
    bool DeleteTeacher(int id);
    bool UpdateTeacher(Teacher teacher);
    bool InsertTeacher(Teacher teacher);
    List<Teacher> GetTeacher();
    Teacher GetTeacherById(int id);
}