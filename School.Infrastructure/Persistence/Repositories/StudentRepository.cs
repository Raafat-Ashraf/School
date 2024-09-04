using School.Infrastructure.Persistence.Abstracts;

namespace School.Infrastructure.Persistence.Repositories;
internal class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    private readonly ApplicationDbContext _context;
    public StudentRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Student>> GetAllAsync()
       => await _context.Students.Include(x => x.Department).ToListAsync();



}
