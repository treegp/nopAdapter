using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class GenericAttribute
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string KeyGroup { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Key { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Value { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int EntityId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> CreatedOrUpdatedDateUTC { get; set; }

    }
}
