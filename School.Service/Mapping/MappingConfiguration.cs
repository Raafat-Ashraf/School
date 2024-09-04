using Mapster;
using School.Data.Entities;

namespace School.Service.Mapping;
internal class MappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Student, StudentResponse>()
            .Map(dest => dest.Department, src => src.Department.Name);
    }
}
