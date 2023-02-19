namespace BlazorServerApp.Services;

public class DatabaseService
{
    protected readonly ApplicationContext DbContext;

    public DatabaseService(ApplicationContext dbContext)
    {
        DbContext = dbContext;
    }
}