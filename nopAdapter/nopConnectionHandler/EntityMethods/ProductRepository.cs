using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductRepository : GenericRepo<Product> , IProductRepository
    {
        string conStr;
        public ProductRepository(string connection) : base(connection) { conStr = connection; }

        public List<Product> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMetaKeywords(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MetaKeywords] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMetaTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MetaTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetBySku(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Sku] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByManufacturerPartNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ManufacturerPartNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByGtin(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Gtin] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByRequiredProductIds(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [RequiredProductIds] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAllowedQuantities(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AllowedQuantities] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByProductTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ProductTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByParentGroupedProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ParentGroupedProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByVisibleIndividually(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [VisibleIndividually] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByShortDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ShortDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByFullDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [FullDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAdminComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AdminComment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByProductTemplateId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ProductTemplateId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByVendorId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [VendorId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByShowOnHomepage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ShowOnHomepage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMetaDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MetaDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAllowCustomerReviews(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AllowCustomerReviews] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByApprovedRatingSum(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ApprovedRatingSum] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByNotApprovedRatingSum(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [NotApprovedRatingSum] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByApprovedTotalReviews(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ApprovedTotalReviews] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByNotApprovedTotalReviews(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [NotApprovedTotalReviews] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetBySubjectToAcl(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [SubjectToAcl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsGiftCard(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsGiftCard] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByGiftCardTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [GiftCardTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByOverriddenGiftCardAmount(Nullable<decimal> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [OverriddenGiftCardAmount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByRequireOtherProducts(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [RequireOtherProducts] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAutomaticallyAddRequiredProducts(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AutomaticallyAddRequiredProducts] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsDownload(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsDownload] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDownloadId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DownloadId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByUnlimitedDownloads(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [UnlimitedDownloads] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMaxNumberOfDownloads(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MaxNumberOfDownloads] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDownloadExpirationDays(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DownloadExpirationDays] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDownloadActivationTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DownloadActivationTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByHasSampleDownload(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [HasSampleDownload] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetBySampleDownloadId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [SampleDownloadId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByHasUserAgreement(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [HasUserAgreement] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByUserAgreementText(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [UserAgreementText] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsRecurring(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsRecurring] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByRecurringCycleLength(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [RecurringCycleLength] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByRecurringCyclePeriodId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [RecurringCyclePeriodId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByRecurringTotalCycles(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [RecurringTotalCycles] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsRental(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsRental] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByRentalPriceLength(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [RentalPriceLength] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByRentalPricePeriodId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [RentalPricePeriodId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsShipEnabled(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsShipEnabled] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsFreeShipping(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsFreeShipping] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByShipSeparately(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ShipSeparately] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAdditionalShippingCharge(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AdditionalShippingCharge] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDeliveryDateId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DeliveryDateId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsTaxExempt(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsTaxExempt] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByTaxCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [TaxCategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByIsTelecommunicationsOrBroadcastingOrElectronicServices(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [IsTelecommunicationsOrBroadcastingOrElectronicServices] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByManageInventoryMethodId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ManageInventoryMethodId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByProductAvailabilityRangeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ProductAvailabilityRangeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByUseMultipleWarehouses(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [UseMultipleWarehouses] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByWarehouseId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [WarehouseId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByStockQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [StockQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDisplayStockAvailability(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DisplayStockAvailability] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDisplayStockQuantity(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DisplayStockQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMinStockQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MinStockQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByLowStockActivityId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [LowStockActivityId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByNotifyAdminForQuantityBelow(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [NotifyAdminForQuantityBelow] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByBackorderModeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [BackorderModeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAllowBackInStockSubscriptions(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AllowBackInStockSubscriptions] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByOrderMinimumQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [OrderMinimumQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByOrderMaximumQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [OrderMaximumQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAllowAddingOnlyExistingAttributeCombinations(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AllowAddingOnlyExistingAttributeCombinations] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByNotReturnable(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [NotReturnable] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDisableBuyButton(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DisableBuyButton] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDisableWishlistButton(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DisableWishlistButton] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAvailableForPreOrder(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AvailableForPreOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByPreOrderAvailabilityStartDateTimeUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [PreOrderAvailabilityStartDateTimeUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByCallForPrice(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [CallForPrice] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Price] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByOldPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [OldPrice] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByProductCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [ProductCost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByCustomerEntersPrice(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [CustomerEntersPrice] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMinimumCustomerEnteredPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MinimumCustomerEnteredPrice] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMaximumCustomerEnteredPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MaximumCustomerEnteredPrice] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByBasepriceEnabled(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [BasepriceEnabled] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByBasepriceAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [BasepriceAmount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByBasepriceUnitId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [BasepriceUnitId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByBasepriceBaseAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [BasepriceBaseAmount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByBasepriceBaseUnitId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [BasepriceBaseUnitId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMarkAsNew(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MarkAsNew] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMarkAsNewStartDateTimeUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MarkAsNewStartDateTimeUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByMarkAsNewEndDateTimeUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [MarkAsNewEndDateTimeUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByHasTierPrices(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [HasTierPrices] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByHasDiscountsApplied(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [HasDiscountsApplied] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByWeight(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Weight] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByLength(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Length] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByWidth(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Width] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByHeight(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Height] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAvailableStartDateTimeUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AvailableStartDateTimeUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByAvailableEndDateTimeUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [AvailableEndDateTimeUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
