using Carthagina.Core.Configuration.DataSourceModels.Abstractions;

namespace Carthagina.Core.Configuration.DataSourceModels
{
    public class ApiDataSource : DataSource
    {
        public string ApiUrl { get; set; }
    }
}