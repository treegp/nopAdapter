using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class EmailAccount
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string DisplayName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Email { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Host { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Username { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Password { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Port { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool EnableSsl { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool UseDefaultCredentials { get; set; }

    }
}
