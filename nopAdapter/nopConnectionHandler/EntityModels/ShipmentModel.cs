using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Shipment
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string TrackingNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<decimal> TotalWeight { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> ShippedDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> DeliveryDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> ReadyForPickupDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AdminComment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
