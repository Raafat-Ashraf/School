namespace School.Data.Entities;
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;


    public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    public ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
}
