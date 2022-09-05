using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IAddressAttributeValueRepository : IGenericRepo<AddressAttributeValue>
    {
        List<AddressAttributeValue> GetById(int value);

        List<AddressAttributeValue> GetByName(string value);

        List<AddressAttributeValue> GetByAddressAttributeId(int value);

        List<AddressAttributeValue> GetByIsPreSelected(bool value);

        List<AddressAttributeValue> GetByDisplayOrder(int value);

    }
}
