using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Address
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> CountryId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> StateProvinceId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FirstName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string LastName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Email { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Company { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string County { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string City { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Address1 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Address2 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ZipPostalCode { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string PhoneNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FaxNumber { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomAttributes { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
