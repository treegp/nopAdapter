using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class RewardPointsHistory
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Points { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> PointsBalance { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal UsedAmount { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Message { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> EndDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ValidPoints { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<Guid> UsedWithOrder { get; set; }

    }
}
