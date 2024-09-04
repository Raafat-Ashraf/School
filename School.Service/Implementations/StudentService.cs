using Mapster;
using Microsoft.EntityFrameworkCore;
using School.Data.Abstractions.Errors;
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

    public async Task<Result<StudentResponse>> GetByIdAsync(int id)
    {
        var student = await _studentRepository.FindAsync(x => x.Id == id, x => x.Include(x => x.Department));
        if (student is null)
            return Result.Failure<StudentResponse>(StudentErrors.StudentNotFound);


        return Result.Success(student.Adapt<StudentResponse>());
    }
}
