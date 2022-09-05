using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class DiscountUsageHistory
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DiscountId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
