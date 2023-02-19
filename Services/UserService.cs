using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerApp.Services;

public class UserService
{
    public async Task<User[]> GetUsersAsync(ApplicationContext dataBase)
    {
        return await dataBase.Users.ToArrayAsync();
    }
    
}