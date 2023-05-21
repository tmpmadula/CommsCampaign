using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ScheduleController : ControllerBase
{
    private readonly IScheduleService _scheduleService;

    public ScheduleController(IScheduleService scheduleService)
    {
        _scheduleService = scheduleService;
    }

    [HttpGet]
    public ActionResult<List<Schedule>> GetScheduledMessages(DateTime scheduledDate, TimeSpan scheduledTime, string partialText)
    {
        var messages = _scheduleService.GetScheduledMessages(scheduledDate, scheduledTime, partialText);
        return messages;
    }
}
