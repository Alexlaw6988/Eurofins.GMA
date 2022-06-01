using CsvHelper.Configuration;

namespace Eurofins.GMA.Application.Contracts.Interfaces
{
    public interface ICsvService<T>
    {
        IEnumerable<T> ReadCsvFile(string fileLocation, ClassMap<T>? columnMap = null);
    }
}
