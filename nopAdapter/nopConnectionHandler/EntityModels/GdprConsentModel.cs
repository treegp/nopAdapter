using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class GdprConsent
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Message { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsRequired { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string RequiredMessage { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool DisplayDuringRegistration { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool DisplayOnCustomerInfoPage { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

    }
}
