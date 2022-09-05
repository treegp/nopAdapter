using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IGenericAttributeRepository : IGenericRepo<GenericAttribute>
    {
        List<GenericAttribute> GetById(int value);

        List<GenericAttribute> GetByKeyGroup(string value);

        List<GenericAttribute> GetByKey(string value);

        List<GenericAttribute> GetByValue(string value);

        List<GenericAttribute> GetByEntityId(int value);

        List<GenericAttribute> GetByStoreId(int value);

        List<GenericAttribute> GetByCreatedOrUpdatedDateUTC(Nullable<DateTime> value);

    }
}
