using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ShipmentItem
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ShipmentId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderItemId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Quantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int WarehouseId { get; set; }

    }
}
