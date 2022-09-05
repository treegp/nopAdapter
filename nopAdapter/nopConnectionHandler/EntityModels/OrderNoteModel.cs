using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class OrderNote
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Note { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DownloadId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool DisplayToCustomer { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
