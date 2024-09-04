using School.Core.Features.Students.Queries.Models;
using School.Service.Abstracts;

namespace School.Core.Features.Students.Queries.Handlers;
public class GetStudentsHandler : IRequestHandler<GetStudentsQuery, IEnumerable<Student>>
{

    private readonly IStudentService _studentService;
    public GetStudentsHandler(IStudentService studentService)
    {
        _studentService = studentService;
    }


    async Task<IEnumerable<Student>> IRequestHandler<GetStudentsQuery, IEnumerable<Student>>.Handle(GetStudentsQuery request, CancellationToken cancellationToken)
    {
        return await _studentService.GetAllAsync();
    }



}
