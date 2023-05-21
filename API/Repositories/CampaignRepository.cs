public class CampaignRepository : ICampaignRepository
{
    private readonly DbContext _dbContext;

    public CampaignRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Campaign> GetAllCampaigns()
    {
        return _dbContext.Campaign.ToList();
    }
}
