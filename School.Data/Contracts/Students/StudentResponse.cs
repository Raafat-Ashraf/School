namespace School.Data.Contracts.Students;
public record StudentResponse(
    int Id,
    string Name,
    string Address,
    string Phone,
    string Department
);
