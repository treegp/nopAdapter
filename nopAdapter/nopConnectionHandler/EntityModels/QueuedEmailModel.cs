using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class QueuedEmail
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string From { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FromName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string To { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ToName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ReplyTo { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ReplyToName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CC { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Bcc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Subject { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int EmailAccountId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PriorityId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Body { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AttachmentFilePath { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AttachmentFileName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AttachedDownloadId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> DontSendBeforeDateUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int SentTries { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> SentOnUtc { get; set; }

    }
}
