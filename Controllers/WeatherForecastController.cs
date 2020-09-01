using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperProfileWithDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper mapper;

        public WeatherForecastController(IAutoMapperBuilder autoMapperBuilder)
        {
            mapper = autoMapperBuilder.Build();
        }

        [HttpGet]
        public string Get()
        {
            MyClass1 class1 = new MyClass1();

            var class2 = mapper.Map<MyClass2>(class1);

            return class2.Message;
        }
    }
}
