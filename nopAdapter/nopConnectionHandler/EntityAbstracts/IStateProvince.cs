using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IStateProvinceRepository : IGenericRepo<StateProvince>
    {
        List<StateProvince> GetById(int value);

        List<StateProvince> GetByName(string value);

        List<StateProvince> GetByAbbreviation(string value);

        List<StateProvince> GetByCountryId(int value);

        List<StateProvince> GetByPublished(bool value);

        List<StateProvince> GetByDisplayOrder(int value);

    }
}
