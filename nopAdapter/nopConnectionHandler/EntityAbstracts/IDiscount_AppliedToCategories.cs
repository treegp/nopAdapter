using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDiscount_AppliedToCategoriesRepository : IGenericRepo<Discount_AppliedToCategories>
    {
        List<Discount_AppliedToCategories> GetByDiscount_Id(int value);

        List<Discount_AppliedToCategories> GetByCategory_Id(int value);

    }
}
