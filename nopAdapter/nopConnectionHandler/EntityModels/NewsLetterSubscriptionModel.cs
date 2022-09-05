using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class NewsLetterSubscription
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Email { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public Guid NewsLetterSubscriptionGuid { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Active { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
