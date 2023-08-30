using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelTest2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.Data.MySqlClient;

namespace HotelTest2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    internal readonly object Rooms;

    //internal readonly object Rooms;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Rooms> rooms { get; set; }
    /*
    protected override void OnModelCreating(ModelBuilder builder)
    {
        //base.OnModelCreating(builder);

        builder.Entity<SelectListItem>();

        //builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
    */



}