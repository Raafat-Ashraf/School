using Mapster;
using School.Infrastructure.Persistence.Abstracts;
using School.Service.Abstracts;

namespace School.Service.Implementations;
internal class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }


    public async Task<Result<IEnumerable<StudentResponse>>> GetAllAsync()
    {
        var students = await _studentRepository.GetAllAsync();

        return Result.Success(students.Adapt<IEnumerable<StudentResponse>>());
    }

}
