public interface IScheduleRepository
{
    List<Schedule> GetScheduledMessages(DateTime scheduledDate, TimeSpan scheduledTime, string partialText);
}
