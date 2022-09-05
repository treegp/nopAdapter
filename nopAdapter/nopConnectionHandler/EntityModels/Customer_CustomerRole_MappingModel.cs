using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Customer_CustomerRole_Mapping
    {
        [GenericRepoModel.Column(true,false,true)]
        public int Customer_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int CustomerRole_Id { get; set; }

    }
}
