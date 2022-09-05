using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class CheckoutAttributeValue
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ColorSquaresRgb { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CheckoutAttributeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PriceAdjustment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal WeightAdjustment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsPreSelected { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

    }
}
