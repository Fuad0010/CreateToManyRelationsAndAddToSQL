using System.Collections.Generic;

namespace CreateToManyRelationsAndAddToSQL.Properties.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<BookGenre> BookGenres { get; set; }
    }
}
