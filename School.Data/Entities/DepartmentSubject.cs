namespace School.Domain.Entities;
public class DepartmentSubject
{
    public int DepartmentId { get; set; }
    public int SubjectId { get; set; }


    public Department Department { get; set; } = default!;
    public Subject Subject { get; set; } = default!;

}
