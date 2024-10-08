using Microsoft.EntityFrameworkCore;
using CreekRiver.Models;

public class CreekRiverDbContext : DbContext
{

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }

    public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // seed data with campsite types
    modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[]
    {
        new CampsiteType {Id = 1, CampsiteTypeName = "Tent", FeePerNight = 15.99M, MaxReservationDays = 7},
        new CampsiteType {Id = 2, CampsiteTypeName = "RV", FeePerNight = 26.50M, MaxReservationDays = 14},
        new CampsiteType {Id = 3, CampsiteTypeName = "Primitive", FeePerNight = 10.00M, MaxReservationDays = 3},
        new CampsiteType {Id = 4, CampsiteTypeName = "Hammock", FeePerNight = 12M, MaxReservationDays = 7}
    });

    modelBuilder.Entity<Campsite>().HasData(new Campsite[]
{
    new Campsite {Id = 1, CampsiteTypeId = 1, Nickname = "Barred Owl", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
    new Campsite { Id = 2, CampsiteTypeId = 2, Nickname = "River Birch", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
    new Campsite { Id = 3, CampsiteTypeId = 3, Nickname = "Whitetail Ridge", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
    new Campsite { Id = 4, CampsiteTypeId = 4, Nickname = "Fox Den", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
    new Campsite { Id = 5, CampsiteTypeId = 1, Nickname = "Cedar Hollow", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhx-wyYEIrvUJlQq2oQqJYTs_cwGeyLniYaA&s" },
    new Campsite { Id = 6, CampsiteTypeId = 2, Nickname = "Pine Haven", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-TAXidJ1UKsB_Kpaav_98bvHAFNrUkfd4dQ&s" }
});

    modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
    {
        new UserProfile { Id = 1, FirstName = "John", LastName = "Doe", Email = "johndoe@example.com" },
        new UserProfile { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "janesmith@example.com" }
    });

    modelBuilder.Entity<Reservation>().HasData(new Reservation[]
{
    new Reservation
    {
        Id = 1,
        CampsiteId = 1,
        UserProfileId = 1,
        CheckinDate = new DateTime(2024, 6, 15),
        CheckoutDate = new DateTime(2024, 6, 20)
    },
    new Reservation
    {
        Id = 2,
        CampsiteId = 2,
        UserProfileId = 2,
        CheckinDate = new DateTime(2024, 7, 5),
        CheckoutDate = new DateTime(2024, 7, 12)
    },
    new Reservation
    {
        Id = 3,
        CampsiteId = 3,
        UserProfileId = 1,
        CheckinDate = new DateTime(2024, 8, 10),
        CheckoutDate = new DateTime(2024, 8, 15)
    }
});


}

    
}