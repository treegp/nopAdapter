using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class GiftCardUsageHistory
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int GiftCardId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int UsedWithOrderId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal UsedValue { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
