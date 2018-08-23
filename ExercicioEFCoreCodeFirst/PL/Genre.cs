using System.Collections.Generic;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}