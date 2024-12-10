using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ISubject
{
    bool DeleteSubject(int id);
    bool UpdateSubject(Subject subject);
    bool InsertSubject(Subject subject);
    List<Subject> GetSubject();
    Subject GetSubjectById(int id);
}