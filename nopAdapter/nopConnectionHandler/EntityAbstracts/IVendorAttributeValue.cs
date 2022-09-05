using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IVendorAttributeValueRepository : IGenericRepo<VendorAttributeValue>
    {
        List<VendorAttributeValue> GetById(int value);

        List<VendorAttributeValue> GetByName(string value);

        List<VendorAttributeValue> GetByVendorAttributeId(int value);

        List<VendorAttributeValue> GetByIsPreSelected(bool value);

        List<VendorAttributeValue> GetByDisplayOrder(int value);

    }
}
