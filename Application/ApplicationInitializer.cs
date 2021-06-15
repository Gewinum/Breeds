using Application.Interfaces;
using Application.Providers;
using Application.Providers.Interfaces;
using Application.Services;
using Application.Services.Interfaces;
using AutoMapper;
using Common;
using Common.Interfaces;
using Common.Mapping;
using Database;
using Database.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Application
{
    public class ApplicationInitializer : IApplicationInitializer
    {
        private ICommonInitializer commonInitializer;

        private IDatabaseInitializer databaseInitializer;

        public void Initialize(IServiceCollection serviceCollection)
        {
            commonInitializer = new CommonInitializer();
            databaseInitializer = new DatabaseInitializer();

            commonInitializer.Initialize(serviceCollection);
            databaseInitializer.Initialize(serviceCollection);

            InitializeProviders(serviceCollection);
            InitializeServices(serviceCollection);
        }

        private void InitializeProviders(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDatabaseProvider, DatabaseProvider>();
        }

        private void InitializeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBreedsService, BreedsService>();
        }
    }
}
