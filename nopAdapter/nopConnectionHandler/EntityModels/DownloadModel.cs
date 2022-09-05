using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Download
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public Guid DownloadGuid { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool UseDownloadUrl { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string DownloadUrl { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public byte[] DownloadBinary { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ContentType { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Filename { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Extension { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsNew { get; set; }

    }
}
