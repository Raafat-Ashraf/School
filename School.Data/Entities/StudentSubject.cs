namespace School.Domain.Entities;

public class StudentSubject
{
    public int StudentId { get; set; }
    public int SubjectId { get; set; }


    public Student Student { get; set; } = default!;
    public Subject Subject { get; set; } = default!;
}
