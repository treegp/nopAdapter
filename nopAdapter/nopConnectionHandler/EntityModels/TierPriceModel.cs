using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class TierPrice
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> CustomerRoleId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Quantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Price { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> StartDateTimeUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> EndDateTimeUtc { get; set; }

    }
}
