using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IClass
{
    bool DeleteClass(int id);
    bool UpdateClass(Class classes);
    bool InsertClass(Class classes);
    List<Class> GetClass();
    Class GetClassById(int id);
}