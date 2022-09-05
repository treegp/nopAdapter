using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICustomerAttributeValueRepository : IGenericRepo<CustomerAttributeValue>
    {
        List<CustomerAttributeValue> GetById(int value);

        List<CustomerAttributeValue> GetByName(string value);

        List<CustomerAttributeValue> GetByCustomerAttributeId(int value);

        List<CustomerAttributeValue> GetByIsPreSelected(bool value);

        List<CustomerAttributeValue> GetByDisplayOrder(int value);

    }
}
