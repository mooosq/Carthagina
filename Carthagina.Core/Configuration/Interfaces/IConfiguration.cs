using Carthagina.Core.Services.Interfaces;

namespace Carthagina.Core.Configuration.Interfaces
{
    public interface IConfiguration
    {
        IDataAccess ConfigureDataSource();
    }
}