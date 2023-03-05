using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Services;

public class AnimalService : DatabaseService
{
    public AnimalService(ApplicationContext dbContext) : base(dbContext)
    {
    }

    
    public async Task<List<Animal>> GetAnimalsAsync()
    {
        return await DbContext.Animals.ToListAsync();
    }
    
    public void UpdateAnimalAsync(Animal animal)
    {
        DbContext.Animals.Update(animal);
        DbContext.SaveChanges();
    }
    
    
}
