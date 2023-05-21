public class Schedule
{
    public int Code { get; set; }
    public int? FK_Campaign { get; set; }
    public DateTime? Start_Date { get; set; }
    public TimeSpan? Start_Time { get; set; }
    public int? Number_Contacts { get; set; }
    public bool? Active { get; set; }
    public bool? Paused { get; set; }
    public DateTime? DateTimeStamp { get; set; }
}
