using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<CharacterTitle> CharacterTitles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Item>().HasData(new List<Item>
        {
            new Item()
            {
                Id = 1,
                Name = "zegar",
                Weight = 100
            },
            new Item()
            {
                Id = 2,
                Name = "piłka",
                Weight = 200
            }
        });
        modelBuilder.Entity<Title>().HasData(new List<Title>
        {
            new Title()
            {
                Id = 1,
                Name = "Władca"
            },
            new Title()
            {
                Id = 2,
                Name = "Wojna"
            }
        });
        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character()
            {
                Id = 1,
                FirstName = "Janusz",
                LastName = "Michlosw",
                CurrentWei = 120,
                MaxWeight = 150
            },
            new Character()
            {
                Id = 2,
                FirstName = "Michal",
                LastName = "januszewski",
                CurrentWei = 90,
                MaxWeight = 120
            }
        });
        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>
        {
            new Backpack()
            {
                CharacterId = 1,
                ItemId = 2,
                Amount = 20
            },
            new Backpack()
            {
                CharacterId = 2,
                ItemId = 1,
                Amount = 10
            }
        });
        modelBuilder.Entity<CharacterTitle>().HasData(new List<CharacterTitle>
        {
            new CharacterTitle()
            {
                CharacterId = 1,
                TitleId = 1,
                AckquiredAt = DateTime.Parse("2024-05-31")
            },
            new CharacterTitle()
            {
                CharacterId = 2,
                TitleId = 2,
                AckquiredAt = DateTime.Parse("2025-01-31")
            }
        });
    }
}