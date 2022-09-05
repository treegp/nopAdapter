using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Forums_Subscription
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public Guid SubscriptionGuid { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ForumId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TopicId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
