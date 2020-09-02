using AutoMapper;

namespace AutoMapperProfileWithDI
{
    public class MyClass : Profile
    {
        public MyClass(IMyService myService)
        {
            if (myService != null)
            {
                CreateMap<MyClass1, MyClass2>()
                    .ForMember(dest => dest.Message, option => option.MapFrom(src => myService.DoSomething()));
            }

        }
    }
}
