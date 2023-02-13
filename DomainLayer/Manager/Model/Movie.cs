using DomainLayer.Manager.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Manager.Model {
    public sealed class Movie {
        public string Title { get; }
        public string ImageUrl { get; }
        public Genre Genre { get; }
        public int Year { get; }

        public Movie(string title, string imageUrl, Genre genre, int year) {
            Title = title;
            ImageUrl = imageUrl;
            Genre = genre;
            Year = year;
        }
    }
}
