using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICustomerRoleRepository : IGenericRepo<CustomerRole>
    {
        List<CustomerRole> GetById(int value);

        List<CustomerRole> GetByName(string value);

        List<CustomerRole> GetBySystemName(string value);

        List<CustomerRole> GetByFreeShipping(bool value);

        List<CustomerRole> GetByTaxExempt(bool value);

        List<CustomerRole> GetByActive(bool value);

        List<CustomerRole> GetByIsSystemRole(bool value);

        List<CustomerRole> GetByEnablePasswordLifetime(bool value);

        List<CustomerRole> GetByOverrideTaxDisplayType(bool value);

        List<CustomerRole> GetByDefaultTaxDisplayTypeId(int value);

        List<CustomerRole> GetByPurchasedWithProductId(int value);

    }
}
