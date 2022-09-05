using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Forums_Forum
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ForumGroupId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Description { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NumTopics { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NumPosts { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LastTopicId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LastPostId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LastPostCustomerId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> LastPostTime { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime UpdatedOnUtc { get; set; }

    }
}
