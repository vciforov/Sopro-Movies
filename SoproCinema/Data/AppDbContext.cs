using Microsoft.EntityFrameworkCore;
using SoproCinema.Models;

namespace SoproCinema.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MovieGenre>().HasKey(mg => new
            {
                mg.MovieId,
                mg.GenreId
            });

            modelBuilder.Entity<MovieGenre>().HasOne(m => m.Movie).WithMany(mg => mg.MovieGenres).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<MovieGenre>().HasOne(g => g.Genre).WithMany(mg => mg.MovieGenres).HasForeignKey(g => g.GenreId);

           

            modelBuilder.Entity<PersonMovieRole>().HasKey(pr => new
            {
                pr.PersonId,
                pr.RoleId,
                pr.MovieId
            });

            modelBuilder.Entity<PersonMovieRole>()
                .HasOne(p => p.Person)
                .WithMany(pr => pr.PersonMovieRoles)
                .HasForeignKey(p => p.PersonId);
            modelBuilder.Entity<PersonMovieRole>()
                .HasOne(r => r.Role)
                .WithMany(pr => pr.PersonMovieRoles)
                .HasForeignKey(r => r.RoleId);
            modelBuilder.Entity<PersonMovieRole>()
                .HasOne(m => m.Movie)
                .WithMany(pr => pr.PersonMovieRoles)
                .HasForeignKey(m => m.MovieId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<PersonMovieRole> PersonMovieRoles { get; set; }


    }
}
