using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ITaxRateRepository : IGenericRepo<TaxRate>
    {
        List<TaxRate> GetById(int value);

        List<TaxRate> GetByStoreId(int value);

        List<TaxRate> GetByTaxCategoryId(int value);

        List<TaxRate> GetByCountryId(int value);

        List<TaxRate> GetByStateProvinceId(int value);

        List<TaxRate> GetByZip(string value);

        List<TaxRate> GetByPercentage(decimal value);

    }
}
