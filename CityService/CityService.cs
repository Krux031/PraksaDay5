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
        protected ICityRepository repository = new Repository();

        public async Task<City> GetCity(int id)
        {
            return await repository.GetCityRep(id);
        }

        public async Task<List<City>> GetAllCity()
        {
            return await repository.GetAllCityRep();
        }

        public async Task<bool> DeleteResident(int id)
        {
            return await repository.DeleteresidentRep(id);
        }

        public async Task<bool> PostResident(Residents res, int id)
        {
            return await repository.PostResidentRep(res, id);
        }
    }
}
