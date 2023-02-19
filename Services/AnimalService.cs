using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerApp.Services;

public class AnimalService
{
    
    public async Task<Animal[]> GetAnimalsAsync(ApplicationContext dataBase)
    {
        return await dataBase.Animals.ToArrayAsync();
    }
    
}