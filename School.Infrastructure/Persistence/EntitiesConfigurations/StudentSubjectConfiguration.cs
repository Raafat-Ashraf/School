namespace School.Infrastructure.Persistence.EntitiesConfigurations;
internal class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
{
    public void Configure(EntityTypeBuilder<StudentSubject> builder)
    {
        builder.HasKey(x => new { x.StudentId, x.SubjectId });
    }
}
