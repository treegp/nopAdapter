using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDiscount_AppliedToProductsRepository : IGenericRepo<Discount_AppliedToProducts>
    {
        List<Discount_AppliedToProducts> GetByDiscount_Id(int value);

        List<Discount_AppliedToProducts> GetByProduct_Id(int value);

    }
}
