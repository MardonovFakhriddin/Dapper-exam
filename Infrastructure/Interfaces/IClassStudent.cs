using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IClassStudent
{
    bool DeleteClassStudent(int id);
    bool UpdateClassStudent(ClassStudent classStudent);
    bool InsertClassStudent(ClassStudent classStudent);
    List<Services.ClassStudent> GetClassStudent();
    Services.ClassStudent? GetClassStudentById(int id);
}