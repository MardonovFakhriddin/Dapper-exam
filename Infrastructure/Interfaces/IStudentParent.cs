using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IStudentParent
{
    bool DeleteStudentParent(int id);
    bool UpdateStudentParent(StudentParent studentParent);
    bool InsertStudentParent(StudentParent studentParent);
    List<StudentParent> GetStudentParent();
    StudentParent GetStudentParentById(int id);
}