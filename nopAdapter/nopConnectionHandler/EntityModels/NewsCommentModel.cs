using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class NewsComment
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NewsItemId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CommentTitle { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CommentText { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsApproved { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
