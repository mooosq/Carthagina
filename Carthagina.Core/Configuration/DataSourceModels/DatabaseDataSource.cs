using Carthagina.Core.Configuration.DataSourceModels.Abstractions;

namespace Carthagina.Core.Configuration.DataSourceModels
{
    public class DatabaseDataSource : DataSource
    {
        public bool UseInMemoryDatabase { get; set; }
        public string ConnectionString { get; set; }
    }
}