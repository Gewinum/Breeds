﻿using Application.Interfaces;
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

        public IServiceCollection Initialize(IServiceCollection serviceCollection)
        {
            commonInitializer = new CommonInitializer();
            databaseInitializer = new DatabaseInitializer();

            serviceCollection = commonInitializer.Initialize(serviceCollection);
            serviceCollection = databaseInitializer.Initialize(serviceCollection);

            serviceCollection = InitializeProviders(serviceCollection);
            serviceCollection = InitializeServices(serviceCollection);

            return serviceCollection;
        }

        private IServiceCollection InitializeProviders(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDatabaseProvider, DatabaseProvider>();

            return serviceCollection;
        }

        private IServiceCollection InitializeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBreedsService, BreedsService>();

            return serviceCollection;
        }
    }
}
