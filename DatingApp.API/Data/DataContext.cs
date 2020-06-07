using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
namespace DatingApp.API.Data
    {
    // datacontext class inherits frm dbcontext which comes from entity framework core which is a object db mapper helps map class Values to db)
    //dbcontext makes a session with the database an instance you could say..
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values{get;set;}
    }
}