namespace School.Infrastructure.Persistence.EntitiesConfigurations;
internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(500);

    }
}
