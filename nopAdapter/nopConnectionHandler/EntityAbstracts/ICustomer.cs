using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICustomerRepository : IGenericRepo<Customer>
    {
        List<Customer> GetById(int value);

        List<Customer> GetByUsername(string value);

        List<Customer> GetByEmail(string value);

        List<Customer> GetByEmailToRevalidate(string value);

        List<Customer> GetBySystemName(string value);

        List<Customer> GetByBillingAddress_Id(Nullable<int> value);

        List<Customer> GetByShippingAddress_Id(Nullable<int> value);

        List<Customer> GetByCustomerGuid(Guid value);

        List<Customer> GetByAdminComment(string value);

        List<Customer> GetByIsTaxExempt(bool value);

        List<Customer> GetByAffiliateId(int value);

        List<Customer> GetByVendorId(int value);

        List<Customer> GetByHasShoppingCartItems(bool value);

        List<Customer> GetByRequireReLogin(bool value);

        List<Customer> GetByFailedLoginAttempts(int value);

        List<Customer> GetByCannotLoginUntilDateUtc(Nullable<DateTime> value);

        List<Customer> GetByActive(bool value);

        List<Customer> GetByDeleted(bool value);

        List<Customer> GetByIsSystemAccount(bool value);

        List<Customer> GetByLastIpAddress(string value);

        List<Customer> GetByCreatedOnUtc(DateTime value);

        List<Customer> GetByLastLoginDateUtc(Nullable<DateTime> value);

        List<Customer> GetByLastActivityDateUtc(DateTime value);

        List<Customer> GetByRegisteredInStoreId(int value);

    }
}
