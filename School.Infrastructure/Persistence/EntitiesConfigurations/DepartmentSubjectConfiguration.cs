
namespace School.Infrastructure.Persistence.EntitiesConfigurations;
internal class DepartmentSubjectConfiguration : IEntityTypeConfiguration<DepartmentSubject>
{
    public void Configure(EntityTypeBuilder<DepartmentSubject> builder)
    {
        builder.HasKey(x => new { x.DepartmentId, x.SubjectId });
    }
}
