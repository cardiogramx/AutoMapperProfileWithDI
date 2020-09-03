using AutoMapper;
using AutoMapperBuilder;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperProfileWithDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper _mapper;

        public WeatherForecastController(IAutoMapperBuilder autoMapperBuilder, IMapper mapper)
        {
            //_mapper = autoMapperBuilder.Build();
            _mapper = mapper;
        }

        [HttpGet]
        public string Get()
        {
            MyClass1 class1 = new MyClass1();

            var class2 = _mapper.Map<MyClass2>(class1);

            return class2.Message;
        }
    }
}
