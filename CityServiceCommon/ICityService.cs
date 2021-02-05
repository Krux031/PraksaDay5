using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityModelCommon;
using CityRepositoryCommon;
using CityModel;

namespace CityServiceCommon
{
    public interface ICityService
    {
        Task<City> GetCity(int id);

        Task<List<City>> GetAllCity();

        Task<bool> DeleteResident(int id);

        Task<bool> PostResident(Residents res, int id);
    }

}
