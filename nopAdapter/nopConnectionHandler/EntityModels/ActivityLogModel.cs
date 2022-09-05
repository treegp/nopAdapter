using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ActivityLog
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Comment { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string IpAddress { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string EntityName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ActivityLogTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> EntityId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
