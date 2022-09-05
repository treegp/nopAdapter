using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Forums_Topic
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Subject { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ForumId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TopicTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NumPosts { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Views { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LastPostId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LastPostCustomerId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> LastPostTime { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime UpdatedOnUtc { get; set; }

    }
}
