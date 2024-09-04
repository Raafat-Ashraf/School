
namespace School.Domain.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public int DepartmentId { get; set; }


    public Department Department { get; set; } = default!;
    public ICollection<StudentSubject> StudentSubjects { get; set; } = new HashSet<StudentSubject>();
}
