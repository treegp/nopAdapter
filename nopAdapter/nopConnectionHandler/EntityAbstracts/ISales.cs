using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ISalesRepository : IGenericRepo<Sales>
    {
        List<Sales> GetById(int value);

        List<Sales> GetByCostumerId(int value);

        List<Sales> GetByCreatedDate(DateTimeOffset value);

        List<Sales> GetByTotalCost(decimal value);

        List<Sales> GetByAddressId(int value);

        List<Sales> GetByStatus(int value);

    }
}
