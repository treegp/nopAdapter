using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class GdprLog
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ConsentId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomerInfo { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RequestTypeId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string RequestDetails { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
