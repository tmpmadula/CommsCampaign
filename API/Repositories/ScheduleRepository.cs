using Microsoft.EntityFrameworkCore;

public class ScheduleRepository : IScheduleRepository
{
    private readonly DbContext _dbContext;

    public ScheduleRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Schedule> GetScheduledMessages(DateTime scheduledDate, TimeSpan scheduledTime, string partialText)
    {
        return _dbContext.Schedule
            .Include(s => s.Campaign)
            .Where(s =>
                s.Start_Date == scheduledDate &&
                s.Start_Time == scheduledTime &&
                s.Campaign.Description.Contains(partialText)
            )
            .OrderBy(s => s.Campaign.Name)
            .ThenBy(s => s.Start_Time)
            .Select(s => new Schedule
            {
                Code = s.Code,
                FK_Campaign = s.FK_Campaign,
                Start_Date = s.Start_Date,
                Start_Time = s.Start_Time,
                Number_Contacts = s.Number_Contacts,
                Active = s.Active,
                Paused = s.Paused,
                DateTimeStamp = s.DateTimeStamp
            })
            .ToList();
    }
}
