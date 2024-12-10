using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ISchool
{
    bool DeleteSchool(int id);
    bool UpdateSchool(School school);
    bool InsertSchool(School school);
    List<School> GetSchool();
    School GetSchoolById(int id);
}