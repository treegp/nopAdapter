using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Customer
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Username { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Email { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string EmailToRevalidate { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SystemName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> BillingAddress_Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ShippingAddress_Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public Guid CustomerGuid { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AdminComment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsTaxExempt { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AffiliateId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int VendorId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool HasShoppingCartItems { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool RequireReLogin { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int FailedLoginAttempts { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> CannotLoginUntilDateUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Active { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Deleted { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsSystemAccount { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string LastIpAddress { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> LastLoginDateUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime LastActivityDateUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RegisteredInStoreId { get; set; }

    }
}
