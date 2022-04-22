using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SoproCinema.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoproCinema.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Genres.Any())
                {
                    context.Genres.AddRange(new List<Genre>()
                    {
                        new Genre()
                        {
                           GenreName="Action"

                        },
                         new Genre()
                        {
                           GenreName="Comedy"

                        },
                           new Genre()
                        {
                           GenreName="Thriller"

                        },
                          new Genre()
                        {
                           GenreName="Horror"

                        },
                        new Genre()
                        {
                           GenreName="Cartoon"

                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Roles.Any())
                {
                    context.Roles.AddRange(new List<Role>()
                    {
                        new Role()
                        {
                           RoleName="Actor"

                        },
                         new Role()
                        {
                           RoleName="Producer"

                        },
                           new Role()
                        {
                           RoleName="Director"

                        }

                    });

                    context.SaveChanges();
                }
                if (!context.Persons.Any())
                {
                    context.Persons.AddRange(new List<Person>()
                    {
                        new Person()
                        {
                          PersonName="Leonardo",
                          PersonLastName="DiCaprio",


                        },
                         new Person()
                        {
                          PersonName="Quentin",
                          PersonLastName="Tarantino",


                        },
                          new Person()
                        {
                          PersonName="Bruce",
                          PersonLastName="Willis",


                        },
                           new Person()
                        {
                          PersonName="Natalie",
                          PersonLastName="Portman",


                        },
                            new Person()
                        {
                          PersonName="Morgan",
                          PersonLastName="Freeman",


                        },


                    });

                    context.SaveChanges();
                }
                

            }

        }
        
    }
}


