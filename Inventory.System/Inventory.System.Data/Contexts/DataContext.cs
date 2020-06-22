using Inventory.System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Inventory.System.Data.Contexts
{
    public class MyDataContext : DbContext, IDisposable
    {

        DbSet<Users> Users { get; set; }
        DbSet<UserDetails> UserDetails {get;set;}

        public MyDataContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
