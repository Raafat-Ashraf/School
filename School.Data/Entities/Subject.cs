namespace School.Domain.Entities;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime Period { get; set; }


    public ICollection<StudentSubject> StudentSubjects { get; set; } = new HashSet<StudentSubject>();
    public ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
}
