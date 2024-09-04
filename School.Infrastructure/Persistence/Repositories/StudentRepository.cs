using School.Infrastructure.Persistence.Abstracts;

namespace School.Infrastructure.Persistence.Repositories;
internal class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;
    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Student>> GetAllAsync()
       => await _context.Students.ToListAsync();



}
