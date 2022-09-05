using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ITaxCategoryRepository : IGenericRepo<TaxCategory>
    {
        List<TaxCategory> GetById(int value);

        List<TaxCategory> GetByName(string value);

        List<TaxCategory> GetByDisplayOrder(int value);

    }
}
