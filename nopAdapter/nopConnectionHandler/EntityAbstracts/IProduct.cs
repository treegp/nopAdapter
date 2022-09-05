using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductRepository : IGenericRepo<Product>
    {
        List<Product> GetById(int value);

        List<Product> GetByName(string value);

        List<Product> GetByMetaKeywords(string value);

        List<Product> GetByMetaTitle(string value);

        List<Product> GetBySku(string value);

        List<Product> GetByManufacturerPartNumber(string value);

        List<Product> GetByGtin(string value);

        List<Product> GetByRequiredProductIds(string value);

        List<Product> GetByAllowedQuantities(string value);

        List<Product> GetByProductTypeId(int value);

        List<Product> GetByParentGroupedProductId(int value);

        List<Product> GetByVisibleIndividually(bool value);

        List<Product> GetByShortDescription(string value);

        List<Product> GetByFullDescription(string value);

        List<Product> GetByAdminComment(string value);

        List<Product> GetByProductTemplateId(int value);

        List<Product> GetByVendorId(int value);

        List<Product> GetByShowOnHomepage(bool value);

        List<Product> GetByMetaDescription(string value);

        List<Product> GetByAllowCustomerReviews(bool value);

        List<Product> GetByApprovedRatingSum(int value);

        List<Product> GetByNotApprovedRatingSum(int value);

        List<Product> GetByApprovedTotalReviews(int value);

        List<Product> GetByNotApprovedTotalReviews(int value);

        List<Product> GetBySubjectToAcl(bool value);

        List<Product> GetByLimitedToStores(bool value);

        List<Product> GetByIsGiftCard(bool value);

        List<Product> GetByGiftCardTypeId(int value);

        List<Product> GetByOverriddenGiftCardAmount(Nullable<decimal> value);

        List<Product> GetByRequireOtherProducts(bool value);

        List<Product> GetByAutomaticallyAddRequiredProducts(bool value);

        List<Product> GetByIsDownload(bool value);

        List<Product> GetByDownloadId(int value);

        List<Product> GetByUnlimitedDownloads(bool value);

        List<Product> GetByMaxNumberOfDownloads(int value);

        List<Product> GetByDownloadExpirationDays(Nullable<int> value);

        List<Product> GetByDownloadActivationTypeId(int value);

        List<Product> GetByHasSampleDownload(bool value);

        List<Product> GetBySampleDownloadId(int value);

        List<Product> GetByHasUserAgreement(bool value);

        List<Product> GetByUserAgreementText(string value);

        List<Product> GetByIsRecurring(bool value);

        List<Product> GetByRecurringCycleLength(int value);

        List<Product> GetByRecurringCyclePeriodId(int value);

        List<Product> GetByRecurringTotalCycles(int value);

        List<Product> GetByIsRental(bool value);

        List<Product> GetByRentalPriceLength(int value);

        List<Product> GetByRentalPricePeriodId(int value);

        List<Product> GetByIsShipEnabled(bool value);

        List<Product> GetByIsFreeShipping(bool value);

        List<Product> GetByShipSeparately(bool value);

        List<Product> GetByAdditionalShippingCharge(decimal value);

        List<Product> GetByDeliveryDateId(int value);

        List<Product> GetByIsTaxExempt(bool value);

        List<Product> GetByTaxCategoryId(int value);

        List<Product> GetByIsTelecommunicationsOrBroadcastingOrElectronicServices(bool value);

        List<Product> GetByManageInventoryMethodId(int value);

        List<Product> GetByProductAvailabilityRangeId(int value);

        List<Product> GetByUseMultipleWarehouses(bool value);

        List<Product> GetByWarehouseId(int value);

        List<Product> GetByStockQuantity(int value);

        List<Product> GetByDisplayStockAvailability(bool value);

        List<Product> GetByDisplayStockQuantity(bool value);

        List<Product> GetByMinStockQuantity(int value);

        List<Product> GetByLowStockActivityId(int value);

        List<Product> GetByNotifyAdminForQuantityBelow(int value);

        List<Product> GetByBackorderModeId(int value);

        List<Product> GetByAllowBackInStockSubscriptions(bool value);

        List<Product> GetByOrderMinimumQuantity(int value);

        List<Product> GetByOrderMaximumQuantity(int value);

        List<Product> GetByAllowAddingOnlyExistingAttributeCombinations(bool value);

        List<Product> GetByNotReturnable(bool value);

        List<Product> GetByDisableBuyButton(bool value);

        List<Product> GetByDisableWishlistButton(bool value);

        List<Product> GetByAvailableForPreOrder(bool value);

        List<Product> GetByPreOrderAvailabilityStartDateTimeUtc(Nullable<DateTime> value);

        List<Product> GetByCallForPrice(bool value);

        List<Product> GetByPrice(decimal value);

        List<Product> GetByOldPrice(decimal value);

        List<Product> GetByProductCost(decimal value);

        List<Product> GetByCustomerEntersPrice(bool value);

        List<Product> GetByMinimumCustomerEnteredPrice(decimal value);

        List<Product> GetByMaximumCustomerEnteredPrice(decimal value);

        List<Product> GetByBasepriceEnabled(bool value);

        List<Product> GetByBasepriceAmount(decimal value);

        List<Product> GetByBasepriceUnitId(int value);

        List<Product> GetByBasepriceBaseAmount(decimal value);

        List<Product> GetByBasepriceBaseUnitId(int value);

        List<Product> GetByMarkAsNew(bool value);

        List<Product> GetByMarkAsNewStartDateTimeUtc(Nullable<DateTime> value);

        List<Product> GetByMarkAsNewEndDateTimeUtc(Nullable<DateTime> value);

        List<Product> GetByHasTierPrices(bool value);

        List<Product> GetByHasDiscountsApplied(bool value);

        List<Product> GetByWeight(decimal value);

        List<Product> GetByLength(decimal value);

        List<Product> GetByWidth(decimal value);

        List<Product> GetByHeight(decimal value);

        List<Product> GetByAvailableStartDateTimeUtc(Nullable<DateTime> value);

        List<Product> GetByAvailableEndDateTimeUtc(Nullable<DateTime> value);

        List<Product> GetByDisplayOrder(int value);

        List<Product> GetByPublished(bool value);

        List<Product> GetByDeleted(bool value);

        List<Product> GetByCreatedOnUtc(DateTime value);

        List<Product> GetByUpdatedOnUtc(DateTime value);

    }
}
