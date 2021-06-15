﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Interfaces
{
    public interface IDatabaseInitializer
    {
        void Initialize(IServiceCollection serviceCollection);
    }
}
