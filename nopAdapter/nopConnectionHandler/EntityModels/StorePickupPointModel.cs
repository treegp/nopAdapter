using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class StorePickupPoint
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Description { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AddressId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PickupFee { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string OpeningHours { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<decimal> Latitude { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<decimal> Longitude { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> TransitDays { get; set; }

    }
}
