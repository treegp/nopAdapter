using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Forums_PrivateMessage
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Subject { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Text { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int FromCustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ToCustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsRead { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsDeletedByAuthor { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsDeletedByRecipient { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
