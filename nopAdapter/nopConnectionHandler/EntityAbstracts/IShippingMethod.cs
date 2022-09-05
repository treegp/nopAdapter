using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShippingMethodRepository : IGenericRepo<ShippingMethod>
    {
        List<ShippingMethod> GetById(int value);

        List<ShippingMethod> GetByName(string value);

        List<ShippingMethod> GetByDescription(string value);

        List<ShippingMethod> GetByDisplayOrder(int value);

    }
}
