using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class CustomerPassword
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Password { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PasswordFormatId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string PasswordSalt { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
