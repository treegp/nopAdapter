using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IAddressRepository : IGenericRepo<Address>
    {
        List<Address> GetById(int value);

        List<Address> GetByCountryId(Nullable<int> value);

        List<Address> GetByStateProvinceId(Nullable<int> value);

        List<Address> GetByFirstName(string value);

        List<Address> GetByLastName(string value);

        List<Address> GetByEmail(string value);

        List<Address> GetByCompany(string value);

        List<Address> GetByCounty(string value);

        List<Address> GetByCity(string value);

        List<Address> GetByAddress1(string value);

        List<Address> GetByAddress2(string value);

        List<Address> GetByZipPostalCode(string value);

        List<Address> GetByPhoneNumber(string value);

        List<Address> GetByFaxNumber(string value);

        List<Address> GetByCustomAttributes(string value);

        List<Address> GetByCreatedOnUtc(DateTime value);

    }
}
