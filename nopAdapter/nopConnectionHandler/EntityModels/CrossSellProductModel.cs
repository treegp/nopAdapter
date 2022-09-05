using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class CrossSellProduct
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId1 { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId2 { get; set; }

    }
}
