using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductAttributeCombination
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Sku { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ManufacturerPartNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Gtin { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AttributesXml { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StockQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowOutOfStockOrders { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<decimal> OverriddenPrice { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NotifyAdminForQuantityBelow { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PictureId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int MinStockQuantity { get; set; }

    }
}
