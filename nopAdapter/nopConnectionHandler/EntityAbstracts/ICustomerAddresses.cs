using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICustomerAddressesRepository : IGenericRepo<CustomerAddresses>
    {
        List<CustomerAddresses> GetByAddress_Id(int value);

        List<CustomerAddresses> GetByCustomer_Id(int value);

    }
}
