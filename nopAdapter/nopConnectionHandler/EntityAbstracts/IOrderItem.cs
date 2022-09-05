using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IOrderItemRepository : IGenericRepo<OrderItem>
    {
        List<OrderItem> GetById(int value);

        List<OrderItem> GetByOrderId(int value);

        List<OrderItem> GetByProductId(int value);

        List<OrderItem> GetByOrderItemGuid(Guid value);

        List<OrderItem> GetByQuantity(int value);

        List<OrderItem> GetByUnitPriceInclTax(decimal value);

        List<OrderItem> GetByUnitPriceExclTax(decimal value);

        List<OrderItem> GetByPriceInclTax(decimal value);

        List<OrderItem> GetByPriceExclTax(decimal value);

        List<OrderItem> GetByDiscountAmountInclTax(decimal value);

        List<OrderItem> GetByDiscountAmountExclTax(decimal value);

        List<OrderItem> GetByOriginalProductCost(decimal value);

        List<OrderItem> GetByAttributeDescription(string value);

        List<OrderItem> GetByAttributesXml(string value);

        List<OrderItem> GetByDownloadCount(int value);

        List<OrderItem> GetByIsDownloadActivated(bool value);

        List<OrderItem> GetByLicenseDownloadId(Nullable<int> value);

        List<OrderItem> GetByItemWeight(Nullable<decimal> value);

        List<OrderItem> GetByRentalStartDateUtc(Nullable<DateTime> value);

        List<OrderItem> GetByRentalEndDateUtc(Nullable<DateTime> value);

    }
}
