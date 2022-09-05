using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Discount
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CouponCode { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AdminComment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DiscountTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool UsePercentage { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal DiscountPercentage { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal DiscountAmount { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<decimal> MaximumDiscountAmount { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> StartDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> EndDateUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool RequiresCouponCode { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsCumulative { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DiscountLimitationId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LimitationTimes { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> MaximumDiscountedQuantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AppliedToSubCategories { get; set; }

    }
}
