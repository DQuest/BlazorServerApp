using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerApp.Services;

public class CityService : DatabaseService
{
    public CityService(ApplicationContext dbContext) : base(dbContext)
    {
    }

    public async Task<City[]> GetCitiesAsync()
    {
        return await DbContext.Cities.ToArrayAsync();
    }
}