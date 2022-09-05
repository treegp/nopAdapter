using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICountryRepository : IGenericRepo<Country>
    {
        List<Country> GetById(int value);

        List<Country> GetByName(string value);

        List<Country> GetByTwoLetterIsoCode(string value);

        List<Country> GetByThreeLetterIsoCode(string value);

        List<Country> GetByAllowsBilling(bool value);

        List<Country> GetByAllowsShipping(bool value);

        List<Country> GetByNumericIsoCode(int value);

        List<Country> GetBySubjectToVat(bool value);

        List<Country> GetByPublished(bool value);

        List<Country> GetByDisplayOrder(int value);

        List<Country> GetByLimitedToStores(bool value);

    }
}
