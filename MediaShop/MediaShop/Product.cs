using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaShop
{
    abstract class Product
    {
        //Variables
        private String name;
        private double price;
        private int artNr;
        private int amount;

        //Attributes. 
        //Restricts ways in which they can be assigned
        //If name contains numbers, price is not bigger than 0, artnr is not 6 digits long...exceptions will be thrown.
        public String Name
        {
            get
            {
                return name;
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
                    name = value;
                }
                if (value.Length <= 0)
                {
                    throw new Exception("Fields are not entered correctly");
                }

                if (value.Length > 0 && isNum)
                {
                    throw new Exception("Name can't contain numbers");
                }


            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {

                if (value > 0)
                {
                    price = value;
                }

                else
                {
                    throw new Exception("Fields are not entered correctly");
                }
            }
        }
        public int ArtNr
        {
            get
            {
                return artNr;
            }
            set
            {


                if (Convert.ToString(value).Length.Equals(6))
                {
                    artNr = value;
                }

                else
                {
                    throw new Exception("Fields are not entered correctly");
                }

            }
        }
        public int Amount
        {
            get { return amount; }

            set
            {

                if (value > 0)
                {
                    amount = value;
                }
                else
                {
                    throw new Exception("Fields are not entered correctly");
                }

            }
        }


    }
}
