using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerApp.Services;

public class UserService : DatabaseService
{
    public UserService(ApplicationContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<User>> GetUsersAsync()
    {
        return await DbContext.Users.ToListAsync();
    }
}