using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class PermissionRecord_Role_Mapping
    {
        [GenericRepoModel.Column(true,false,true)]
        public int PermissionRecord_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int CustomerRole_Id { get; set; }

    }
}
