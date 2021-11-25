using Carthagina.Core.Configuration.DataSourceModels.Abstractions;

namespace Carthagina.Core.Configuration.DataSourceModels
{
    public class FileDataSource : DataSource
    {
        public string FilePath { get; set; }
    }
}