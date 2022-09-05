using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IOrderRepository : IGenericRepo<Order>
    {
        List<Order> GetById(int value);

        List<Order> GetByCustomOrderNumber(string value);

        List<Order> GetByBillingAddressId(int value);

        List<Order> GetByCustomerId(int value);

        List<Order> GetByPickupAddressId(Nullable<int> value);

        List<Order> GetByShippingAddressId(Nullable<int> value);

        List<Order> GetByOrderGuid(Guid value);

        List<Order> GetByStoreId(int value);

        List<Order> GetByPickupInStore(bool value);

        List<Order> GetByOrderStatusId(int value);

        List<Order> GetByShippingStatusId(int value);

        List<Order> GetByPaymentStatusId(int value);

        List<Order> GetByPaymentMethodSystemName(string value);

        List<Order> GetByCustomerCurrencyCode(string value);

        List<Order> GetByCurrencyRate(decimal value);

        List<Order> GetByCustomerTaxDisplayTypeId(int value);

        List<Order> GetByVatNumber(string value);

        List<Order> GetByOrderSubtotalInclTax(decimal value);

        List<Order> GetByOrderSubtotalExclTax(decimal value);

        List<Order> GetByOrderSubTotalDiscountInclTax(decimal value);

        List<Order> GetByOrderSubTotalDiscountExclTax(decimal value);

        List<Order> GetByOrderShippingInclTax(decimal value);

        List<Order> GetByOrderShippingExclTax(decimal value);

        List<Order> GetByPaymentMethodAdditionalFeeInclTax(decimal value);

        List<Order> GetByPaymentMethodAdditionalFeeExclTax(decimal value);

        List<Order> GetByTaxRates(string value);

        List<Order> GetByOrderTax(decimal value);

        List<Order> GetByOrderDiscount(decimal value);

        List<Order> GetByOrderTotal(decimal value);

        List<Order> GetByRefundedAmount(decimal value);

        List<Order> GetByRewardPointsHistoryEntryId(Nullable<int> value);

        List<Order> GetByCheckoutAttributeDescription(string value);

        List<Order> GetByCheckoutAttributesXml(string value);

        List<Order> GetByCustomerLanguageId(int value);

        List<Order> GetByAffiliateId(int value);

        List<Order> GetByCustomerIp(string value);

        List<Order> GetByAllowStoringCreditCardNumber(bool value);

        List<Order> GetByCardType(string value);

        List<Order> GetByCardName(string value);

        List<Order> GetByCardNumber(string value);

        List<Order> GetByMaskedCreditCardNumber(string value);

        List<Order> GetByCardCvv2(string value);

        List<Order> GetByCardExpirationMonth(string value);

        List<Order> GetByCardExpirationYear(string value);

        List<Order> GetByAuthorizationTransactionId(string value);

        List<Order> GetByAuthorizationTransactionCode(string value);

        List<Order> GetByAuthorizationTransactionResult(string value);

        List<Order> GetByCaptureTransactionId(string value);

        List<Order> GetByCaptureTransactionResult(string value);

        List<Order> GetBySubscriptionTransactionId(string value);

        List<Order> GetByPaidDateUtc(Nullable<DateTime> value);

        List<Order> GetByShippingMethod(string value);

        List<Order> GetByShippingRateComputationMethodSystemName(string value);

        List<Order> GetByCustomValuesXml(string value);

        List<Order> GetByDeleted(bool value);

        List<Order> GetByCreatedOnUtc(DateTime value);

        List<Order> GetByRedeemedRewardPointsEntryId(Nullable<int> value);

    }
}
