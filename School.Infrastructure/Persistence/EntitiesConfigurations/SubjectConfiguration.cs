namespace School.Infrastructure.Persistence.EntitiesConfigurations;
internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(500);
    }
}
