public class ScheduleService : IScheduleService
{
    private readonly IScheduleRepository _scheduleRepository;

    public ScheduleService(IScheduleRepository scheduleRepository)
    {
        _scheduleRepository = scheduleRepository;
    }

    public List<Schedule> GetScheduledMessages(DateTime scheduledDate, TimeSpan scheduledTime, string partialText)
    {
        return _scheduleRepository.GetScheduledMessages(scheduledDate, scheduledTime, partialText);
    }
}
