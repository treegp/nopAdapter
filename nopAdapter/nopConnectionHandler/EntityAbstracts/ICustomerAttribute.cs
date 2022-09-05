using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICustomerAttributeRepository : IGenericRepo<CustomerAttribute>
    {
        List<CustomerAttribute> GetById(int value);

        List<CustomerAttribute> GetByName(string value);

        List<CustomerAttribute> GetByIsRequired(bool value);

        List<CustomerAttribute> GetByAttributeControlTypeId(int value);

        List<CustomerAttribute> GetByDisplayOrder(int value);

    }
}
