using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IScheduleTaskRepository : IGenericRepo<ScheduleTask>
    {
        List<ScheduleTask> GetById(int value);

        List<ScheduleTask> GetByName(string value);

        List<ScheduleTask> GetByType(string value);

        List<ScheduleTask> GetBySeconds(int value);

        List<ScheduleTask> GetByLastEnabledUtc(Nullable<DateTime> value);

        List<ScheduleTask> GetByEnabled(bool value);

        List<ScheduleTask> GetByStopOnError(bool value);

        List<ScheduleTask> GetByLastStartUtc(Nullable<DateTime> value);

        List<ScheduleTask> GetByLastEndUtc(Nullable<DateTime> value);

        List<ScheduleTask> GetByLastSuccessUtc(Nullable<DateTime> value);

    }
}
