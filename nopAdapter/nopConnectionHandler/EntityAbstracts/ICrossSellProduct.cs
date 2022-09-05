using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICrossSellProductRepository : IGenericRepo<CrossSellProduct>
    {
        List<CrossSellProduct> GetById(int value);

        List<CrossSellProduct> GetByProductId1(int value);

        List<CrossSellProduct> GetByProductId2(int value);

    }
}
