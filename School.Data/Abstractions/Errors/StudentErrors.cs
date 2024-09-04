using Microsoft.AspNetCore.Http;

namespace School.Data.Abstractions.Errors;

public static class StudentErrors
{
    public static readonly Error StudentNotFound = new("Student.NotFound", "No Student was found with the given ID", StatusCodes.Status404NotFound);

    // public static readonly Error DuplicatedPollTitle = new("Poll.DuplicatedPollTitle", "Another poll with the same title is already exists", StatusCodes.Status409Conflict);
}
