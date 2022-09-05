using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class CustomerAddresses
    {
        [GenericRepoModel.Column(true,false,true)]
        public int Address_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int Customer_Id { get; set; }

    }
}
