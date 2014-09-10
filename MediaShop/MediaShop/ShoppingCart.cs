using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaShop
{
    class ShoppingCart: List<Product>
    {
        //variables
        private double sum;

        //Attributes
        public double Sum { get { return sum ;} set { sum = value; } }

        //Constructor
        public ShoppingCart()
        {

        }

        //Takes a product and adds to the list. Takes the price of the product in question and adds it to the sum
        //of the contents in the shoppingcart
        public void addToCart(Product p)
        {
            this.Add(p);

            Sum += p.Price;
        }

        
        //Adds to the sum of the contens in the shoppingcart
        public void addToSum(double i)
        {
            Sum += i;
        }

        //For each product in the shoppingcart, take attributes and convert into and append to string divided by dots
        //and ended with a linebreak after every product to make a string list of products in the shoppingcart that is returned.
        public String getContents()
        {
            String content= "";
            
            //First checks products in general and then specifiec to get the unique attributes for each subclass
            foreach (Product p in this)
            {
                content += p.ArtNr + " . " + p.Name + " . " + p.Price + " . ";

                if (p is Book)
                {
                    Book b = (Book)p;
                  
                     content +=  b.Author + " . " + b.Amount + "\n";
                }
                else if (p is Dvd)
                {
                    Dvd d = (Dvd)p;
                    content += d.Director + " . " + d.Amount + "\n";
                }
                else if (p is Cd)
                {
                    Cd c = (Cd)p;
                    content += c.Artist + " . " + c.Amount + "\n";
                }
                else if (p is Game)
                {
                    Game g = (Game)p;
                    content += g.Producer + g.Amount + "\n";
                }
            }
            
            return content;
        }

        //Checks if a certain products is contained within the shoppingcart by comparing an incoming artnr with the product
        //artnr's in the shoppingcart
        public bool hasProduct(String s)
        {

            foreach (Product p in this)
            {
                if (p.ArtNr == Convert.ToInt32(s))
                {
                    return true;
                }
            }

            return false;

        }

        //Fetches the product in the shoppingcart that has the same artnr as the incoming parameter value
        //Returns null if product is not found
        public Product getProduct(String s)
        {
            foreach (Product p in this)
            {
                if (p.ArtNr == Convert.ToInt32(s))
                {
                    return p;
                }
            }
            return null;
        }

    }
}
