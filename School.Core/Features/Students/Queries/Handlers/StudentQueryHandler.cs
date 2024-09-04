
namespace School.Core.Features.Students.Queries.Handlers;

public class StudentQueryHandler :
    IRequestHandler<GetStudentsQuery, Result<IEnumerable<StudentResponse>>>,
    IRequestHandler<GetStudentByIdQuery, Result<StudentResponse>>
{

    private readonly IStudentService _studentService;
    public StudentQueryHandler(IStudentService studentService)
    {
        _studentService = studentService;
    }


    async Task<Result<IEnumerable<StudentResponse>>> IRequestHandler<GetStudentsQuery, Result<IEnumerable<StudentResponse>>>.Handle(GetStudentsQuery request, CancellationToken cancellationToken)
    {
        return await _studentService.GetAllAsync();
    }


    public Task<Result<StudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        return _studentService.GetByIdAsync(request.Id);
    }


}
