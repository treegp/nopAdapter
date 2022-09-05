using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ShippingMethodRestrictions
    {
        [GenericRepoModel.Column(true,false,true)]
        public int ShippingMethod_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int Country_Id { get; set; }

    }
}
