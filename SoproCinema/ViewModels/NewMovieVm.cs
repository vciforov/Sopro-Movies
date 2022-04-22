using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoproCinema.Models;

namespace SoproCinema.ViewModels
{
    public class NewMovieVm
    {
        public int MovieId { get; set; }    

        [Display(Name = "Movie Title")]
        [Required(ErrorMessage = "Movie Title is required")]
        public string MovieName { get; set; }


        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Movie Release Date is required")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Movie Rating")]
        public double MovieRatings { get; set; }

        [Display(Name = "IMDB Link")]
        public string ImdbLink { get; set; }

        
        [Display(Name = "Movie Length")]
        [Required(ErrorMessage = "Movie Length Date is required")]
        public int Length { get; set; }


        [Display(Name = "Movie Description")]
        public string Description { get; set; }
            
        //Relationships

        [Display(Name = "Genres")]
        [Required(ErrorMessage = "Movie Genre is required")]
        public List<int> GenreIds { get; set; }


        [Display(Name = "Actors")]
        [Required(ErrorMessage = "Movie Cast is required")]
        public List<int> ActorsIds { get; set; }

        [Display(Name = "Directors")]
        [Required(ErrorMessage = "Movie Cast is required")]
        public List<int> DirectorsIds { get; set; }

        [Display(Name = "Producers")]    
        [Required(ErrorMessage = "Movie Cast is required")]
        public List<int> ProducersIds { get; set; }
    }
}       
