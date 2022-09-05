using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class AclRecord
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string EntityName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerRoleId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int EntityId { get; set; }

    }
}
