using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityServiceCommon;
using CityModelCommon;
using CityRepositoryCommon;
using CityModel;
using CityRepository;

namespace CityService
{
    public class Service : ICityService
    {
        protected ICityRepository Repository = new Repository();

        public async Task<City> GetCity(int id)
        {
            return await Repository.GetCityRep(id);
        }

        public async Task<List<City>> GetAllCity()
        {
            return await Repository.GetAllCityRep();
        }

        public async Task<bool> DeleteResident(int id)
        {
            return await Repository.DeleteresidentRep(id);
        }

        public async Task<bool> PostResident(Residents res, int id)
        {
            return await Repository.PostResidentRep(res, id);
        }
    }
}
