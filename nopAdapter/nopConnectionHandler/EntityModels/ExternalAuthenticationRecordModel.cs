using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ExternalAuthenticationRecord
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Email { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ExternalIdentifier { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ExternalDisplayIdentifier { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string OAuthToken { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string OAuthAccessToken { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ProviderSystemName { get; set; }

    }
}
