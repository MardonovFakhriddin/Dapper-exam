using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IParent
{
    bool DeleteParent(int id);
    bool UpdateParent(Parent parent);
    bool InsertParent(Parent parent);
    List<Parent> GetParent();
    Parent GetParentById(int id);
}