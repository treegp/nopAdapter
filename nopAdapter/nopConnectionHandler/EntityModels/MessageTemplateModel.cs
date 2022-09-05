using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class MessageTemplate
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string BccEmailAddresses { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Subject { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int EmailAccountId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Body { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsActive { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> DelayBeforeSend { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DelayPeriodId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AttachedDownloadId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

    }
}
