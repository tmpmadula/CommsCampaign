public class Campaign
{
    public int Code { get; set; }
    public int? FK_Message { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool? Active { get; set; }
}
