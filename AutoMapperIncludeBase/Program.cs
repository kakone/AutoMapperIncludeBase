using AutoMapper;
using AutoMapperIncludeBase;

var configuration = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Foo, FooDto>()
        .IncludeBase<FooBase, FooDtoBase>();

    cfg.CreateMap<FooBase, FooDtoBase>()
        .IncludeBase<FooBaseBase, FooDtoBaseBase>();

    cfg.CreateMap<FooBaseBase, FooDtoBaseBase>()
       .ForMember(d => d.Date, o => o.MapFrom(s => s.Today ? (DateTime?)DateTime.Today : null));
});
configuration.AssertConfigurationIsValid();

Console.WriteLine("Hello, World!");
