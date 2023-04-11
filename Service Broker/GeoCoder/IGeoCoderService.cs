using DataModel;

namespace Service_Broker.Public
{
    public interface IGeoCoderService
    {
        Task<List<GeoCode_Data>> GetGeoCodeAsync(string loc = "Dayton OH");
    }
}