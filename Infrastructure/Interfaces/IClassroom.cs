using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IClassroom
{
    bool DeleteClassroom(int id);
    bool UpdateClassroom(Classroom classroom);
    bool InsertClassroom(Classroom classroom);
    List<Classroom> GetClassroom();
    Classroom GetClassroomById(int id);
}