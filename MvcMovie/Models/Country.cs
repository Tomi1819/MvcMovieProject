using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string CountryName { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
