using Microsoft.EntityFrameworkCore;
using SubiektGT.Models;

public class AppDbContext : DbContext
{
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Client> Clients { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>()
            .ToTable("ksef_Faktury");

        modelBuilder.Entity<Invoice>()
            .Property(i => i.Id)
            .HasColumnName("ksef_Id");

        modelBuilder.Entity<Invoice>()
            .Property(i => i.Numer)
            .HasColumnName("ksef_Numer");

        modelBuilder.Entity<Invoice>()
            .Property(i => i.Kontrahent)
            .HasColumnName("ksef_Kontrahent");

        modelBuilder.Entity<Invoice>()
            .Property(i => i.Wartosc)
            .HasColumnName("ksef_WartoscBrutto");

        modelBuilder.Entity<Client>()
            .ToTable("vwKlienci");

        modelBuilder.Entity<Client>()
            .Property(i => i.Id)
            .HasColumnName("adr_Id");

        modelBuilder.Entity<Client>()
            .Property(i => i.Name)
            .HasColumnName("adr_Nazwa");

        modelBuilder.Entity<Client>()
            .Property(i => i.Email)
            .HasColumnName("kh_EMail");
    }
}