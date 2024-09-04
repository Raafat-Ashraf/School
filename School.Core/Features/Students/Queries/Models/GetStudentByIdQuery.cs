namespace School.Application.Features.Students.Queries.Models;

public record GetStudentByIdQuery(int Id) : IRequest<Result<StudentResponse>>;
