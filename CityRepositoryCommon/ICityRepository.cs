using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityModelCommon;
using CityModel;

namespace CityRepositoryCommon
{
    public interface ICityRepository
    {
        Task<City> GetCityRep(int id);

        Task<List<City>> GetAllCityRep();

        Task<bool> DeleteresidentRep(int id);

        Task<bool> PostResidentRep(Residents res, int id);
    }
}
