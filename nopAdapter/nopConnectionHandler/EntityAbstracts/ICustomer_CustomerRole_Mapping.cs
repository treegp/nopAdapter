using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICustomer_CustomerRole_MappingRepository : IGenericRepo<Customer_CustomerRole_Mapping>
    {
        List<Customer_CustomerRole_Mapping> GetByCustomer_Id(int value);

        List<Customer_CustomerRole_Mapping> GetByCustomerRole_Id(int value);

    }
}
