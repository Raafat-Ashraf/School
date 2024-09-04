
namespace School.Infrastructure.Persistence.Abstracts;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllAsync();
}
