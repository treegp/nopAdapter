using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class StockQuantityHistory
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int QuantityAdjustment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StockQuantity { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Message { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> CombinationId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> WarehouseId { get; set; }

    }
}
