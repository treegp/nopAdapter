using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Addresses
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Address { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Tel { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CostumerId { get; set; }

    }
}
