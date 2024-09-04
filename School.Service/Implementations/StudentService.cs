using School.Data.Entities;
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


    public async Task<Result<IEnumerable<Student>>> GetAllAsync()
    {
        return Result.Success(await _studentRepository.GetAllAsync());
    }



}
