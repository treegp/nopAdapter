using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Product
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaKeywords { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaTitle { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Sku { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ManufacturerPartNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Gtin { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string RequiredProductIds { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AllowedQuantities { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ParentGroupedProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool VisibleIndividually { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ShortDescription { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FullDescription { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AdminComment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductTemplateId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int VendorId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool ShowOnHomepage { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaDescription { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowCustomerReviews { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ApprovedRatingSum { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NotApprovedRatingSum { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ApprovedTotalReviews { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NotApprovedTotalReviews { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool SubjectToAcl { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsGiftCard { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int GiftCardTypeId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<decimal> OverriddenGiftCardAmount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool RequireOtherProducts { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AutomaticallyAddRequiredProducts { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsDownload { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DownloadId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool UnlimitedDownloads { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int MaxNumberOfDownloads { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> DownloadExpirationDays { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DownloadActivationTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool HasSampleDownload { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int SampleDownloadId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool HasUserAgreement { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string UserAgreementText { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsRecurring { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RecurringCycleLength { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RecurringCyclePeriodId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RecurringTotalCycles { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsRental { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RentalPriceLength { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RentalPricePeriodId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsShipEnabled { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsFreeShipping { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool ShipSeparately { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal AdditionalShippingCharge { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DeliveryDateId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsTaxExempt { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TaxCategoryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsTelecommunicationsOrBroadcastingOrElectronicServices { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ManageInventoryMethodId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductAvailabilityRangeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool UseMultipleWarehouses { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int WarehouseId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StockQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool DisplayStockAvailability { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool DisplayStockQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int MinStockQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LowStockActivityId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NotifyAdminForQuantityBelow { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int BackorderModeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowBackInStockSubscriptions { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderMinimumQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderMaximumQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool NotReturnable { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool DisableBuyButton { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool DisableWishlistButton { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AvailableForPreOrder { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> PreOrderAvailabilityStartDateTimeUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool CallForPrice { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Price { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OldPrice { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal ProductCost { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool CustomerEntersPrice { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal MinimumCustomerEnteredPrice { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal MaximumCustomerEnteredPrice { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool BasepriceEnabled { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal BasepriceAmount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int BasepriceUnitId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal BasepriceBaseAmount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int BasepriceBaseUnitId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool MarkAsNew { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> MarkAsNewStartDateTimeUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> MarkAsNewEndDateTimeUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool HasTierPrices { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool HasDiscountsApplied { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Weight { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Length { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Width { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Height { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> AvailableStartDateTimeUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> AvailableEndDateTimeUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Deleted { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime UpdatedOnUtc { get; set; }

    }
}
