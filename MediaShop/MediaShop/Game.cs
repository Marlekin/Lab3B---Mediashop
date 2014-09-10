using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaShop
{
    class Game : Product
    {
        //Variables
        private String producer;

        //Attributes
        public String Producer
        {
            get
            {
                return producer;
            }

            set
            {
                producer = value;
            }
        }

        //Constructor
        public Game(int anArtNr, String aName, double aPrice, String aProducer, int anAmount)
        {
            this.Name = aName;
            this.ArtNr = anArtNr;
            this.Price = aPrice;
            this.Producer = aProducer;
            this.Amount = anAmount;

        }

    }
}
