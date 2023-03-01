namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvailbleCopies { get; set; }
    }
}
