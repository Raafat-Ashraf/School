using School.Core.Features.Students.Queries.Models;

namespace School.Core.Features.Students.Queries.Handlers;
public class GetStudentsHandler : IRequestHandler<GetStudentsQuery, Result<IEnumerable<Student>>>
{

    private readonly IStudentService _studentService;
    public GetStudentsHandler(IStudentService studentService)
    {
        _studentService = studentService;
    }

    public async Task<Result<IEnumerable<Student>>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
    {
        return await _studentService.GetAllAsync();
    }
}
