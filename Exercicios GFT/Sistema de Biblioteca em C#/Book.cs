using System;
namespace Biblioteca  

{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }

        public dynamic BookStatus()
        {
           bool isOpen=false;
           return isOpen;
        }         
    }
}
