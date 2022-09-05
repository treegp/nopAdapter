using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductWarehouseInventory
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int WarehouseId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StockQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ReservedQuantity { get; set; }

    }
}
