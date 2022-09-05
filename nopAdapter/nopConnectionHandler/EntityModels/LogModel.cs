using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Log
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string ShortMessage { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string IpAddress { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LogLevelId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FullMessage { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string PageUrl { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ReferrerUrl { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
