using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaShop
{
    class CashierController
    {
        //Variables
        private CashierView _cv;
        private FileManager _fm;
        private ShoppingCart _sc;

        //Constructor
        //Instantiates Shoppingcart for all methods to operate against
        public CashierController(CashierView cv, FileManager fm)
        {
            _cv = cv;
            _fm = fm;
            _sc = new ShoppingCart();

        }

        //When the staff wants to add a product to the shoppingcart. First checks that the artnr from the input is 6 digits
        //and that the amount from the input is not 0. Then searches the file for the product containing the artnr.
        //When found, the product string is split into an array, separating attributes. A check for wether or not 
        //the product already exists in the shoppingcart list. If not, then checks if the amount of the 
        //product is greater or equal to the amount from the input. If not, then a warning is displayed. Else it checks
        //the type of product and instansiates and adds a product of appropriate type to the cart. Then the view is updated.
        //If the product already existed in the list the existing post would instead be updated with amount.
        public void addClick(object sender, EventArgs e)
        {


            if (Convert.ToString(_cv.getartNr()).Length.Equals(6))
            {
                if (_cv.getAmount() != 0 && _cv.getAmount() > 0)
                {
                    if (_fm.search(Convert.ToString(_cv.getartNr())))
                    {
                        String s = _fm.getProduct(Convert.ToString(_cv.getartNr()).Split('.').First());
                        String[] product = new String[5];
                        product = _fm.getProduct(Convert.ToString(_cv.getartNr())).Split('.');
                        product[0] = product[0].Split(':').Last();

                       
                        if (!_sc.hasProduct(product[0]))
                        {
                            if (_cv.getAmount() <= Convert.ToInt32(product[4]))
                            {

                                if (s.Contains("BOOK") && _cv.getAmount() > 0)
                                {
                                    try
                                    {
                                        Book b = new Book(Convert.ToInt32(product[0]), product[1], Convert.ToDouble(product[2]) * _cv.getAmount(), product[3], _cv.getAmount());
                                        _sc.addToCart(b);
                                    }

                                    catch (Exception ex)
                                    {
                                        _cv.getErrorMessage(ex.Message);
                                    }


                                }


                                if (s.Contains("CD") && _cv.getAmount() > 0)
                                {
                                    try
                                    {
                                        Cd c = new Cd(Convert.ToInt32(product[0]), product[1], Convert.ToDouble(product[2]) * _cv.getAmount(), product[3], _cv.getAmount());
                                        _sc.addToCart(c);
                                    }

                                    catch (Exception ex)
                                    {
                                        _cv.getErrorMessage(ex.Message);
                                    }


                                }
                                if (s.Contains("DVD") && _cv.getAmount() > 0)
                                {
                                    try
                                    {

                                        Dvd d = new Dvd(Convert.ToInt32(product[0]), product[1], Convert.ToDouble(product[2]) * _cv.getAmount(), product[3], _cv.getAmount());
                                        _sc.addToCart(d);
                                    }

                                    catch (Exception ex)
                                    {
                                        _cv.getErrorMessage(ex.Message);
                                    }

                                }
                                if (s.Contains("GAME") && _cv.getAmount() > 0)
                                {
                                    try
                                    {
                                        Game g = new Game(Convert.ToInt32(product[0]), product[1], Convert.ToDouble(product[2]) * _cv.getAmount(), product[3], _cv.getAmount());
                                        _sc.addToCart(g);
                                    }
                                    catch (Exception ex)
                                    {
                                        _cv.getErrorMessage(ex.Message);
                                    }

                                }
                                _cv.getPriceLabel().Text = "Sumtotal: " + _sc.Sum;
                                _cv.updateCart(_sc.getContents());
                            }
                            else
                            {
                                _cv.getErrorMessage("Not that many in stock");
                            }

                        }
                        else
                        {
                            int next = _sc.getProduct(product[0]).Amount + _cv.getAmount();

                            if (next <= Convert.ToInt32(product[4]))
                            {
                                _sc.getProduct(product[0]).Amount += _cv.getAmount();
                                _sc.getProduct(product[0]).Price += Convert.ToDouble(product[2]);
                                _sc.addToSum(Convert.ToDouble(product[2]) * _cv.getAmount());
                                _cv.getPriceLabel().Text = "Sumtotal: " + _sc.Sum;
                                _cv.updateCart(_sc.getContents());
                            }

                            else
                            {
                                _cv.getErrorMessage("Not that many in stock");
                            }
                        }
                    }
                    else
                    {
                        _cv.getErrorMessage("Product with this ArtNr does not exist");
                    }
                }
                else
                {
                    _cv.getErrorMessage("Amount must be positive");
                }
            }
            else
            {

                _cv.getErrorMessage("ArtNr must constist of 6 numbers");
            }

        }

        //When the staff wants to remove an item from the shoppingcart. Iterates through the shoppingcart.
        //Where the artnr matches with the artnr from the input, a message for confirmation will be displayed.
        //If yes, the product in question will be removed from the shoppingcart and the sum will be recalculated 
        //Then the view will be updated.
        public void removeClick(object sender, EventArgs e)
        {
           
            String[] product = new String[5];
            product = _fm.getProduct(Convert.ToString(_cv.getartNr())).Split('.');
            product[0] = product[0].Split(':').Last();

            for (int i = _sc.Count - 1; i >= 0; i--)
            {

                if (_sc[i].ArtNr == _cv.getartNr())
                {
                    if(MessageBox.Show("This will remove the entire post, Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){

                      
                        _sc.Sum -= Convert.ToDouble(product[2]) * _sc.getProduct(Convert.ToString(_cv.getartNr())).Amount;
                        _sc.RemoveAt(i);
                       
                        _cv.getPriceLabel().Text = "Sumtotal: " + _sc.Sum;
                       

                        
                    
                }

                }
            }

            _cv.updateCart(_sc.getContents());

        }

        //When a purchase wants to be finalized. First checks that the contents of the cart is not empty.
        //Then asks for confirmation of purchase. If yes, each article post in the file will be updated
        //with the subtracted amount of sold corresponding articles. Also asks for confirmation on receipt
        //If yes, then the contents of the cart, the total sum and a receipt header is printed.
        //Then the view is updated and cart cleared.
        public void purchaseClick(object sender, EventArgs e)
        {

            if (_cv.getCartContent() != "")
            {

                if (MessageBox.Show("Confirm purchase?", "Observe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    foreach (Product p in _sc)
                    {
                        _fm.updatePost(Convert.ToString(p.ArtNr), Convert.ToString(-p.Amount));
                    }



                    if (MessageBox.Show("Do you want to print a receipt?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _fm.print("-------------------Simons Lilla Affär-------------------\n\nArtiklar:\n" + _cv.getCartContent() + "\n" + _cv.getPriceLabel().Text);
                        
                    }
                    _cv.updateCart("");
                    _cv.updateProducts(_fm.FileContent);
                    _sc.Clear();
                }
                
            }
            else
            {
                _cv.getErrorMessage("No articles in Shoppingcart");
            }

        }

        //For when the staff wants to hide the search form. Makes the form invisible
        public void closeSearch(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _cv.hideSearch();
        }

        //For when the staff wants to show the search form. Makes the form visible
        public void openSearchClick(object sender, EventArgs e)
        {
            
            _cv.showSearch();
            
        }

        //For when the staff uses the search function. First check that corresponding input fields are not empty.
        //If they are not the product list from FileManager will be iterated through and compared to the search input.
        //If a match is found the product string and a line break will be appended to a result string. 
        //Then the view will be updated with the results
        public void searchClick(object sender, EventArgs e)
        {
            String result = "";

            if (_cv.getArtnrSearch() != "")
            {
                String artnr = "";

               foreach (String c in _fm.getProductList())
               {
                   artnr= c.Split('.').First().Split(':').Last();

                   if (artnr.Contains(_cv.getArtnrSearch()))
                   {

                       result += c + "\n";
                   }
               }
            }
            if (_cv.getNameSearch() != "")
            {
                String name = "";

                foreach (String c in _fm.getProductList())
                {
                    name = c.Split('.').ElementAt(1);
                    
                    if (name.ToLower().Contains(_cv.getNameSearch().ToLower()))
                    {

                        result += c + "\n";
                    }
                }
            }
            if (_cv.getUniqueSearch() != "")
            {
                String unique = "";

                foreach (String c in _fm.getProductList())
                {
                    unique = c.Split('.').ElementAt(3);

                    if (unique.ToLower().Contains(_cv.getUniqueSearch().ToLower()))
                    {

                        result += c + "\n";
                    }
                }
            }

            _cv.updateResults(result);
            
        }

        //For when the staff returns an item. First checks if artnr has a correct length. Will create a messagebox
        //to ask for confirmation. If yes, the correspondin article post in the file is updated with an increased amount of 1.
        //If the artnr from the input was not the correct length, an error message will be displayed.
        public void returnClick(object sender, EventArgs e)
        {
            if (_cv.getartNr() != 0 && Convert.ToString(_cv.getartNr()).Length.Equals(6))
            {
                if (MessageBox.Show("This will return 1pc of " + _cv.getartNr() + ", Continue?", "Observe", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    _fm.updatePost(Convert.ToString(_cv.getartNr()), "1");
                    _cv.updateProducts(_fm.FileContent);
                }
            }
            else
            {
                _cv.getErrorMessage("ArtNr must consist of 6 numbers");
            }

        }



    }
}
