using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IAddressesRepository : IGenericRepo<Addresses>
    {
        List<Addresses> GetById(int value);

        List<Addresses> GetByAddress(string value);

        List<Addresses> GetByTel(string value);

        List<Addresses> GetByCostumerId(int value);

    }
}
