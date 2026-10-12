using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain1.Entities;

namespace Infrasturcture.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext( DbContextOptions<AppDBContext> options) : base (options)  { 
        
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
