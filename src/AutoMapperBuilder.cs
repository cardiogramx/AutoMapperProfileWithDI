using System.Collections.Generic;
using Microsoft.Extensions.Options;

using AutoMapper;

namespace AutoMapperBuilder
{
    public interface IAutoMapperBuilder
    {
        IMapper Build();
    }

    public class AutoMapperBuilder : IAutoMapperBuilder
    {
        private List<Profile> Profiles { get; }

        public AutoMapperBuilder(IOptions<AutoMapperBuilderConfiguration> options)
        {
            Profiles = options.Value.Profiles;
        }

        public IMapper Build()
        {
            return new MapperConfiguration(c => c.AddProfiles(Profiles)).CreateMapper();
        }
    }
}
