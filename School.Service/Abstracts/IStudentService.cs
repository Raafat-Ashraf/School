
namespace School.Service.Abstracts;

public interface IStudentService
{
    Task<Result<IEnumerable<StudentResponse>>> GetAllAsync();
}
