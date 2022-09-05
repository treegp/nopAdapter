using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IVendorAttributeRepository : IGenericRepo<VendorAttribute>
    {
        List<VendorAttribute> GetById(int value);

        List<VendorAttribute> GetByName(string value);

        List<VendorAttribute> GetByIsRequired(bool value);

        List<VendorAttribute> GetByDisplayOrder(int value);

        List<VendorAttribute> GetByAttributeControlTypeId(int value);

    }
}
