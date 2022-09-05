using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Picture
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string MimeType { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SeoFilename { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AltAttribute { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string TitleAttribute { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsNew { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string VirtualPath { get; set; }

    }
}
