using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Order
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string CustomOrderNumber { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int BillingAddressId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> PickupAddressId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ShippingAddressId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public Guid OrderGuid { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool PickupInStore { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderStatusId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ShippingStatusId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PaymentStatusId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string PaymentMethodSystemName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomerCurrencyCode { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal CurrencyRate { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerTaxDisplayTypeId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string VatNumber { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderSubtotalInclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderSubtotalExclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderSubTotalDiscountInclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderSubTotalDiscountExclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderShippingInclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderShippingExclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PaymentMethodAdditionalFeeInclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PaymentMethodAdditionalFeeExclTax { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string TaxRates { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderDiscount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderTotal { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal RefundedAmount { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> RewardPointsHistoryEntryId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CheckoutAttributeDescription { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CheckoutAttributesXml { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerLanguageId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AffiliateId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomerIp { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowStoringCreditCardNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CardType { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CardName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CardNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MaskedCreditCardNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CardCvv2 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CardExpirationMonth { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CardExpirationYear { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AuthorizationTransactionId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AuthorizationTransactionCode { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AuthorizationTransactionResult { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CaptureTransactionId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CaptureTransactionResult { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SubscriptionTransactionId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> PaidDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ShippingMethod { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ShippingRateComputationMethodSystemName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomValuesXml { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Deleted { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> RedeemedRewardPointsEntryId { get; set; }

    }
}
