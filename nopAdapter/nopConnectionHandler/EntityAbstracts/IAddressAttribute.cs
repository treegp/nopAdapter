using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IAddressAttributeRepository : IGenericRepo<AddressAttribute>
    {
        List<AddressAttribute> GetById(int value);

        List<AddressAttribute> GetByName(string value);

        List<AddressAttribute> GetByIsRequired(bool value);

        List<AddressAttribute> GetByAttributeControlTypeId(int value);

        List<AddressAttribute> GetByDisplayOrder(int value);

    }
}
