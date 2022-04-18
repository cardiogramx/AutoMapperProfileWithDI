using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperProfileWithDI
{
    public class MyClass : Profile
    {
        public MyClass(IServiceCollection collection)
        {
            if (collection != null)
            {
                var provider = collection.BuildServiceProvider();
                var myService = provider.GetRequiredService<IMyService>();

                CreateMap<MyClass1, MyClass2>()
                    .ForMember(dest => dest.Message, option => option.MapFrom(src => myService.DoSomething()));
            }

        }
    }
}
