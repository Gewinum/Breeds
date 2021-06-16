﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationInitializer
    {
        IServiceCollection Initialize(IServiceCollection serviceCollection);
    }
}
