using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Store
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Url { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Hosts { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CompanyName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CompanyAddress { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CompanyPhoneNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CompanyVat { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool SslEnabled { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DefaultLanguageId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

    }
}
