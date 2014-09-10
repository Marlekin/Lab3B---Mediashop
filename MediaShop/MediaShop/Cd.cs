using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaShop
{
    class Cd : Product
    {
        //Variables
        private String artist;

        //Attributes
        public String Artist
        {
            get
            {
                return artist;
            }
            set
            {
                bool isNum = false;

                foreach (char c in value)
                {
                    if (char.IsNumber(c))
                    {
                        isNum = true;
                    }
                }

                if (value.Length > 0)
                {
                    artist = value;
                }
                if (value.Length <= 0)
                {
                    throw new Exception("Fields are not entered correctly");
                }

                if (value.Length > 0 && isNum)
                {
                    throw new Exception("artist can't contain numbers");
                }


            }
        }

        //Constructor
        public Cd(int anArtNr, String aName, double aPrice, String anArtist, int anAmount)
        {
            this.Name = aName;
            this.ArtNr = anArtNr;
            this.Price = aPrice;
            this.Artist = anArtist;
            this.Amount = anAmount;

        }

    }
}
