using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductReviewHelpfulness
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductReviewId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool WasHelpful { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

    }
}
