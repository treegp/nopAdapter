using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IWarehouseRepository : IGenericRepo<Warehouse>
    {
        List<Warehouse> GetById(int value);

        List<Warehouse> GetByName(string value);

        List<Warehouse> GetByAdminComment(string value);

        List<Warehouse> GetByAddressId(int value);

    }
}
