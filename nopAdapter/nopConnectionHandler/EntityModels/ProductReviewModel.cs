using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductReview
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsApproved { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Title { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ReviewText { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ReplyText { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool CustomerNotifiedOfReply { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Rating { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int HelpfulYesTotal { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int HelpfulNoTotal { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
