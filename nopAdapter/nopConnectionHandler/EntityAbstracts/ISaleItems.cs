using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ISaleItemsRepository : IGenericRepo<SaleItems>
    {
        List<SaleItems> GetById(int value);

        List<SaleItems> GetByProductId(int value);

        List<SaleItems> GetByCost(decimal value);

        List<SaleItems> GetBySaleId(int value);

    }
}
