using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShippingByWeightByTotalRecordRepository : IGenericRepo<ShippingByWeightByTotalRecord>
    {
        List<ShippingByWeightByTotalRecord> GetById(int value);

        List<ShippingByWeightByTotalRecord> GetByWeightFrom(decimal value);

        List<ShippingByWeightByTotalRecord> GetByWeightTo(decimal value);

        List<ShippingByWeightByTotalRecord> GetByOrderSubtotalFrom(decimal value);

        List<ShippingByWeightByTotalRecord> GetByOrderSubtotalTo(decimal value);

        List<ShippingByWeightByTotalRecord> GetByAdditionalFixedCost(decimal value);

        List<ShippingByWeightByTotalRecord> GetByPercentageRateOfSubtotal(decimal value);

        List<ShippingByWeightByTotalRecord> GetByRatePerWeightUnit(decimal value);

        List<ShippingByWeightByTotalRecord> GetByLowerWeightLimit(decimal value);

        List<ShippingByWeightByTotalRecord> GetByZip(string value);

        List<ShippingByWeightByTotalRecord> GetByStoreId(int value);

        List<ShippingByWeightByTotalRecord> GetByWarehouseId(int value);

        List<ShippingByWeightByTotalRecord> GetByCountryId(int value);

        List<ShippingByWeightByTotalRecord> GetByStateProvinceId(int value);

        List<ShippingByWeightByTotalRecord> GetByShippingMethodId(int value);

        List<ShippingByWeightByTotalRecord> GetByTransitDays(Nullable<int> value);

    }
}
