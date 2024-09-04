
namespace School.Core.Features.Students.Queries.Handlers;

public class GetStudentsHandler : IRequestHandler<GetStudentsQuery, Result<IEnumerable<StudentResponse>>>
{

    private readonly IStudentService _studentService;
    public GetStudentsHandler(IStudentService studentService)
    {
        _studentService = studentService;
    }

    async Task<Result<IEnumerable<StudentResponse>>> IRequestHandler<GetStudentsQuery, Result<IEnumerable<StudentResponse>>>.Handle(GetStudentsQuery request, CancellationToken cancellationToken)
    {
        return await _studentService.GetAllAsync();
    }
}
