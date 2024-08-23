using GlobalAeroTechnicalTest.Model;

namespace GlobalAeroTechnicalTest.Data;

public interface IAirportDatabase
{
    IList<AirportModel> GetByCountry(string countryCode);
    IList<AirportModel> LondonAirports { get; }

}