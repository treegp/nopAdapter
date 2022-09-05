using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class MigrationVersionInfo
    {
        [GenericRepoModel.Column(true,false,false)]
        public long Version { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> AppliedOn { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Description { get; set; }

    }
}
