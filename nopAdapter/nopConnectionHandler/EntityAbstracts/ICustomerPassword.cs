using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICustomerPasswordRepository : IGenericRepo<CustomerPassword>
    {
        List<CustomerPassword> GetById(int value);

        List<CustomerPassword> GetByCustomerId(int value);

        List<CustomerPassword> GetByPassword(string value);

        List<CustomerPassword> GetByPasswordFormatId(int value);

        List<CustomerPassword> GetByPasswordSalt(string value);

        List<CustomerPassword> GetByCreatedOnUtc(DateTime value);

    }
}
