using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class OrderItem
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public Guid OrderItemGuid { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Quantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal UnitPriceInclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal UnitPriceExclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PriceInclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PriceExclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal DiscountAmountInclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal DiscountAmountExclTax { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OriginalProductCost { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AttributeDescription { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AttributesXml { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DownloadCount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsDownloadActivated { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> LicenseDownloadId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<decimal> ItemWeight { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> RentalStartDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> RentalEndDateUtc { get; set; }

    }
}
