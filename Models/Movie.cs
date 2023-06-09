﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTicket.Data.Enums;

namespace eTicket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        // Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }


    }
}
