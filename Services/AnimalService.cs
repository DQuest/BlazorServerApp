using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Services;

public class AnimalService : DatabaseService
{
    public AnimalService(ApplicationContext dbContext) : base(dbContext)
    {
    }

    
    public async Task<Animal[]> GetAnimalsAsync()
    {
        return await DbContext.Animals.ToArrayAsync();
    }
}