using School.Data.Entities;

namespace School.Service.Abstracts;

public interface IStudentService
{
    Task<IEnumerable<Student>> GetAllAsync();
}
