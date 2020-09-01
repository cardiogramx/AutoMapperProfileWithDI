using AutoMapper;

namespace AutoMapperProfileWithDI
{
    public class MyProfile : Profile
    {
        public MyProfile(IMyService myService)
        {
            myService.DoSomething();

            CreateMap<MyClass1, MyClass2>()
                .ForMember(dest => dest.Message, option => option.MapFrom(src => myService.DoSomething()));
        }
    }
}
