using System;
using Carthagina.Core.Configuration.DataSourceModels;
using Carthagina.Core.Configuration.DataSourceModels.Abstractions;
using Carthagina.Core.Exceptions;
using Carthagina.Core.Services;
using Carthagina.Core.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Carthagina.Core.Configuration
{
    public class Configuration : Interfaces.IConfiguration
    {
        public IDataAccess ConfigureDataSource()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("ConfigurationFiles\\config.json").Build();

            var databaseConfig = config.GetSection(nameof(DatabaseDataSource)).Get<DatabaseDataSource>();

            if (databaseConfig.IsDataSourceEnabled && databaseConfig.UseInMemoryDatabase)
                return new DatabaseAccessService();
            
            var fileConfig = config.GetSection(nameof(FileDataSource)).Get<FileDataSource>();

            if (fileConfig.IsDataSourceEnabled)
                return new FileAccessService();
            
            var apiConfig = config.GetSection(nameof(ApiDataSource)).Get<ApiDataSource>();

            if (apiConfig.IsDataSourceEnabled)
                return new ApiAccess();

            throw new AccessServiceNotFoundException("No access service specified in config file");
        }
    }
}