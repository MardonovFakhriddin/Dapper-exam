namespace Infrastructure.Interfaces;
using Domain.Models;

public interface IStudent
{
    bool DeleteStudent(int id);
    bool UpdateStudent(Student student);
    bool InsertStudent(Student student);
    List<Student> GetStudent();
    Student GetStudentById(int id);
}