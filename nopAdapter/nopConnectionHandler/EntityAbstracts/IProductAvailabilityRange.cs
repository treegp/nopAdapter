using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductAvailabilityRangeRepository : IGenericRepo<ProductAvailabilityRange>
    {
        List<ProductAvailabilityRange> GetById(int value);

        List<ProductAvailabilityRange> GetByName(string value);

        List<ProductAvailabilityRange> GetByDisplayOrder(int value);

    }
}
