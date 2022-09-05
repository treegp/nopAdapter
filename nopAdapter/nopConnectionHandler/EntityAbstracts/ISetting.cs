using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ISettingRepository : IGenericRepo<Setting>
    {
        List<Setting> GetById(int value);

        List<Setting> GetByName(string value);

        List<Setting> GetByValue(string value);

        List<Setting> GetByStoreId(int value);

    }
}
