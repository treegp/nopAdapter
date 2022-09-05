using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Forums_PostVote
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ForumPostId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsUp { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
