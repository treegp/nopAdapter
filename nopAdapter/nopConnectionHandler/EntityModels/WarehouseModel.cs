using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Warehouse
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string AdminComment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AddressId { get; set; }

    }
}
