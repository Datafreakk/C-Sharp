using Microsoft.Extensions.Configuration;

namespace MoqIconfig;

public class DatabaseService
{
    private readonly IConfiguration _configuration;

    public DatabaseService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetConnectionString()
    {
        return _configuration.GetSection("DatabaseSettings").GetSection("ConnectionString").Value;
    }
    
    public string GetProvider()
    {
        return _configuration.GetSection("DatabaseSettings").GetSection("Provider").Value;
    }
    
}
