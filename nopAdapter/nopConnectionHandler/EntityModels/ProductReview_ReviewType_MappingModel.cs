using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductReview_ReviewType_Mapping
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductReviewId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ReviewTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Rating { get; set; }

    }
}
