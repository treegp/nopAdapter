using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class OrderRepository : GenericRepo<Order> , IOrderRepository
    {
        string conStr;
        public OrderRepository(string connection) : base(connection) { conStr = connection; }

        public List<Order> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCustomOrderNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CustomOrderNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByBillingAddressId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [BillingAddressId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByPickupAddressId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [PickupAddressId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByShippingAddressId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [ShippingAddressId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderGuid(Guid value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderGuid] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByPickupInStore(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [PickupInStore] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderStatusId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderStatusId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByShippingStatusId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [ShippingStatusId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByPaymentStatusId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [PaymentStatusId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByPaymentMethodSystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [PaymentMethodSystemName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCustomerCurrencyCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CustomerCurrencyCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCurrencyRate(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CurrencyRate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCustomerTaxDisplayTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CustomerTaxDisplayTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByVatNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [VatNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderSubtotalInclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderSubtotalInclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderSubtotalExclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderSubtotalExclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderSubTotalDiscountInclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderSubTotalDiscountInclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderSubTotalDiscountExclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderSubTotalDiscountExclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderShippingInclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderShippingInclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderShippingExclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderShippingExclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByPaymentMethodAdditionalFeeInclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [PaymentMethodAdditionalFeeInclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByPaymentMethodAdditionalFeeExclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [PaymentMethodAdditionalFeeExclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByTaxRates(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [TaxRates] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderDiscount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderDiscount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByOrderTotal(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [OrderTotal] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByRefundedAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [RefundedAmount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByRewardPointsHistoryEntryId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [RewardPointsHistoryEntryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCheckoutAttributeDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CheckoutAttributeDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCheckoutAttributesXml(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CheckoutAttributesXml] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCustomerLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CustomerLanguageId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByAffiliateId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [AffiliateId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCustomerIp(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CustomerIp] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByAllowStoringCreditCardNumber(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [AllowStoringCreditCardNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCardType(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CardType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCardName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CardName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCardNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CardNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByMaskedCreditCardNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [MaskedCreditCardNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCardCvv2(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CardCvv2] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCardExpirationMonth(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CardExpirationMonth] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCardExpirationYear(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CardExpirationYear] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByAuthorizationTransactionId(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [AuthorizationTransactionId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByAuthorizationTransactionCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [AuthorizationTransactionCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByAuthorizationTransactionResult(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [AuthorizationTransactionResult] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCaptureTransactionId(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CaptureTransactionId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCaptureTransactionResult(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CaptureTransactionResult] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetBySubscriptionTransactionId(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [SubscriptionTransactionId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByPaidDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [PaidDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByShippingMethod(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [ShippingMethod] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByShippingRateComputationMethodSystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [ShippingRateComputationMethodSystemName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCustomValuesXml(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CustomValuesXml] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Order> GetByRedeemedRewardPointsEntryId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Order where [RedeemedRewardPointsEntryId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
