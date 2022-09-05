using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShippingMethodRestrictionsRepository : IGenericRepo<ShippingMethodRestrictions>
    {
        List<ShippingMethodRestrictions> GetByShippingMethod_Id(int value);

        List<ShippingMethodRestrictions> GetByCountry_Id(int value);

    }
}
