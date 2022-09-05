using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IStoreRepository : IGenericRepo<Store>
    {
        List<Store> GetById(int value);

        List<Store> GetByName(string value);

        List<Store> GetByUrl(string value);

        List<Store> GetByHosts(string value);

        List<Store> GetByCompanyName(string value);

        List<Store> GetByCompanyAddress(string value);

        List<Store> GetByCompanyPhoneNumber(string value);

        List<Store> GetByCompanyVat(string value);

        List<Store> GetBySslEnabled(bool value);

        List<Store> GetByDefaultLanguageId(int value);

        List<Store> GetByDisplayOrder(int value);

    }
}
