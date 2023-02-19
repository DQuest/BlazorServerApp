using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerApp.Services;

public class CityService
{
    public async Task<City[]> GetCitiesAsync(ApplicationContext dataBase)
    {
        return await dataBase.Cities.ToArrayAsync();
    }
    
}