using Database.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        public IServiceCollection Initialize(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<DatabaseContext>();

            return serviceCollection;
        }
    }
}
