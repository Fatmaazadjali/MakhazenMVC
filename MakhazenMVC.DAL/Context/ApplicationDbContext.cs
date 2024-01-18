using MakhazenMVC.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MakhazenMVC.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) {
        
        
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Consumer> consumers { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Provider> providers{ get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<User> users { get; set; }



    }
}
