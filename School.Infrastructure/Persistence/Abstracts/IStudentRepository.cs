
namespace School.Infrastructure.Persistence.Abstracts;

public interface IStudentRepository : IGenericRepository<Student>
{
    Task<IEnumerable<Student>> GetAllAsync();
}
