using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IStoreMappingRepository : IGenericRepo<StoreMapping>
    {
        List<StoreMapping> GetById(int value);

        List<StoreMapping> GetByEntityName(string value);

        List<StoreMapping> GetByStoreId(int value);

        List<StoreMapping> GetByEntityId(int value);

    }
}
