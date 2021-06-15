using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ICommonInitializer
    {
        void Initialize(IServiceCollection serviceCollection);
    }
}
