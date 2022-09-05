using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Affiliate
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AddressId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AdminComment { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FriendlyUrlName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Deleted { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Active { get; set; }

    }
}
