using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDiscountRepository : IGenericRepo<Discount>
    {
        List<Discount> GetById(int value);

        List<Discount> GetByName(string value);

        List<Discount> GetByCouponCode(string value);

        List<Discount> GetByAdminComment(string value);

        List<Discount> GetByDiscountTypeId(int value);

        List<Discount> GetByUsePercentage(bool value);

        List<Discount> GetByDiscountPercentage(decimal value);

        List<Discount> GetByDiscountAmount(decimal value);

        List<Discount> GetByMaximumDiscountAmount(Nullable<decimal> value);

        List<Discount> GetByStartDateUtc(Nullable<DateTime> value);

        List<Discount> GetByEndDateUtc(Nullable<DateTime> value);

        List<Discount> GetByRequiresCouponCode(bool value);

        List<Discount> GetByIsCumulative(bool value);

        List<Discount> GetByDiscountLimitationId(int value);

        List<Discount> GetByLimitationTimes(int value);

        List<Discount> GetByMaximumDiscountedQuantity(Nullable<int> value);

        List<Discount> GetByAppliedToSubCategories(bool value);

    }
}
