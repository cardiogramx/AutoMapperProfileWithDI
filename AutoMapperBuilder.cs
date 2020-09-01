using AutoMapper;

namespace AutoMapperProfileWithDI
{
    public interface IAutoMapperBuilder
    {
        IMapper Build();
    }

    public class AutoMapperBuilder : IAutoMapperBuilder
    {
        private readonly IMyService myService;

        public AutoMapperBuilder(IMyService myService)
        {
            this.myService = myService;
        }

        public IMapper Build()
        {
            return new MapperConfiguration(c => c.AddProfile(new MyProfile(myService))).CreateMapper();
        }
    }
}
