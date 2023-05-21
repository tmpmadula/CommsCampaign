public interface IScheduleService
{
    List<Schedule> GetScheduledMessages(DateTime scheduledDate, TimeSpan scheduledTime, string partialText);
}
