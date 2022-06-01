using CsvHelper;
using CsvHelper.Configuration;
using Eurofins.GMA.Application.Contracts.Interfaces;
using System.Globalization;

namespace Eurofins.GMA.Application.Implementations
{
    public class CsvService<T> : ICsvService<T>
    {
        public IEnumerable<T> ReadCsvFile(string fileLocation, ClassMap<T>? columnMap = null)
        {
            try
            {
                using TextReader reader = new StreamReader(fileLocation);
                using var csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.CurrentCulture));
                if (columnMap != null)
                {
                    csvReader.Context.RegisterClassMap(columnMap);
                }
                return csvReader.GetRecords<T>().ToList();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
