using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaShop
{
    class Book: Product
    {
        //Variables
        private String author;
        
        //Attributes
        public String Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        //Constructor
        public Book(int anArtNr, String aName, double aPrice, String anAuthor, int anAmount)
        {
            this.Name = aName;
            this.ArtNr = anArtNr;
            this.Price = aPrice;
            this.Author = anAuthor;
            this.Amount = anAmount;
           
        }

    }
}
