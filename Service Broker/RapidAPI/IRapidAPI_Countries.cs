using DataModel;

namespace Service_Broker.RapidAPI
{
    public interface IRapidAPI_Countries
    {
        Task<CountriesModel> GetCountriesAsync();
    }
}