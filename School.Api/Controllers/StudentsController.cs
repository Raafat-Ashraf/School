using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Api.Extensions;
using School.Application.Features.Students.Queries.Models;

namespace School.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IMediator _mediator;
    public StudentsController(IMediator mediator)
    {
        _mediator = mediator;
    }



    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetStudentsQuery());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _mediator.Send(new GetStudentByIdQuery(id));

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }
}
