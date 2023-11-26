using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication2
{
public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<UsersModel> Users{get;set;}
}

}