using Common.Interfaces;
using Common.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommonInitializer : ICommonInitializer
    {
        public IServiceCollection Initialize(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(configuration => configuration.AddProfile(new MappingProfile()));

            return serviceCollection;
        }
    }
}
