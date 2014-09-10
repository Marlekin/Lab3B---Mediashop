using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaShop
{
    class Dvd : Product
    {
        //Variables
        private String director;

        //Attributes
        public String Director
        {
            get
            {
                return director;
            }

            set
            {
                director = value;
            }
        }

        //Constructor
        public Dvd(int anArtNr, String aName, double aPrice, String aDirector, int anAmount)
        {
            this.Name = aName;
            this.ArtNr = anArtNr;
            this.Price = aPrice;
            this.Director = aDirector;
            this.Amount = anAmount;

        }


    }
}
