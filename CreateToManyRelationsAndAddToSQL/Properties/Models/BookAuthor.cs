using System.Collections.Generic;

namespace CreateToManyRelationsAndAddToSQL.Properties.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        //public List<BookAuthor> BookAuthors { get; set; }
    }
}
