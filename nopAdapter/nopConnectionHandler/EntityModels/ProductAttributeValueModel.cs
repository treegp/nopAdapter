using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductAttributeValue
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ColorSquaresRgb { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductAttributeMappingId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AttributeValueTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AssociatedProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ImageSquaresPictureId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PriceAdjustment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool PriceAdjustmentUsePercentage { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal WeightAdjustment { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Cost { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool CustomerEntersQty { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Quantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsPreSelected { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PictureId { get; set; }

    }
}
