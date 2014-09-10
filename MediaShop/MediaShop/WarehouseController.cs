using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace MediaShop
{
    class WarehouseController
    {
        //Variables
        private WarehouseView _wv;
        private FileManager _fm;

        //Constructor
        public WarehouseController(WarehouseView wv, FileManager fm)
        {
            _wv = wv;
            _fm = fm;
        }

        //Depending on active tab, tries to instantiate a product of appropriate type and save it's data to file
        //and the update the view. If failed, an error message will be displayed
        public void addClick(object sender, EventArgs e)
        {

            if (_wv.getActiveTab() == "Book")
            {
                try
                {
                    Book b = new Book(_wv.getProductArtNr(), _wv.getProductName(), _wv.getProductPrice(), _wv.getProductUnique(), _wv.getProductAmount());

                    _fm.convertAndSave("BOOK", b.ArtNr, b.Name, b.Price, b.Author, _wv.getProductAmount());
                    _wv.updateProducts(_fm.FileContent);


                }
                catch(Exception ex)
                {
                    _wv.getErrorMessage(ex.Message);
                }

            }
            if (_wv.getActiveTab() == "Cd")
            {
                try
                {
                    Cd c = new Cd(_wv.getProductArtNr(), _wv.getProductName(), _wv.getProductPrice(), _wv.getProductUnique(), _wv.getProductAmount());

                    _fm.convertAndSave("CD", c.ArtNr, c.Name, c.Price, c.Artist, c.Amount);
                    _wv.updateProducts(_fm.FileContent);

                }
                catch (Exception ex)
                {
                    _wv.getErrorMessage(ex.Message);
                }
            }
            if (_wv.getActiveTab() == "Dvd")
            {
                try
                {
                    Dvd d = new Dvd(_wv.getProductArtNr(), _wv.getProductName(), _wv.getProductPrice(), _wv.getProductUnique(), _wv.getProductAmount());

                    _fm.convertAndSave("DVD", d.ArtNr, d.Name, d.Price, d.Director, d.Amount);
                    _wv.updateProducts(_fm.FileContent);

                }
                catch (Exception ex)
                {
                    _wv.getErrorMessage(ex.Message);
                }
            }
            if (_wv.getActiveTab() == "Game")
            {
                try
                {
                    Game g = new Game(_wv.getProductArtNr(), _wv.getProductName(), _wv.getProductPrice(), _wv.getProductUnique(), _wv.getProductAmount());

                    _fm.convertAndSave("GAME", g.ArtNr, g.Name, g.Price, g.Producer, g.Amount);
                    _wv.updateProducts(_fm.FileContent);



                }
                catch (Exception ex)
                {
                    _wv.getErrorMessage(ex.Message);
                }
                
            }


        }

        //First checks if given artnr consists of 6 digits. If yes, then checks if amount is not 0. If yet again yes, then
        //The corresponding article post in the file is updated with the new amount. Then the view is updated.
        //If the artnr was not consisting of 6 digits, an error message will be displayed.
        public void deliveryClick(object sender, EventArgs e)
        {
            if (Convert.ToString(_wv.getDeliveryArtNr()).Length.Equals(6))
            {
                if (_wv.getDeliveryAmount() != 0)
                {
                    if (_wv.getDeliveryAmount() > 0)
                    {
                        //Change post
                        _fm.updatePost(Convert.ToString(_wv.getDeliveryArtNr()), Convert.ToString(_wv.getDeliveryAmount()));
                        _wv.updateProducts(_fm.FileContent);
                    }
                    else
                    {
                        _wv.getErrorMessage("Number of products delivered must be greater than 0");
                    }
                }
                else
                {
                    _wv.getErrorMessage("Number of products delivered must be greater than 0");
                }
               
            }

            else
            {
                _wv.getErrorMessage("ArtNr must constist of 6 numbers");
            }
        }

        //First checks if artnr consists of 6 digits. If yes, then tries to remove the article post 
        //(checked in filemanager if the amount of the product is not 0) where the given artnr
        //matches and then updates the view. Else shows an error message.
        public void removeClick(object sender, EventArgs e)
        {
            if (Convert.ToString(_wv.getRemoveArtNr()).Length.Equals(6))
            {
                _fm.remove(Convert.ToString(_wv.getRemoveArtNr()));
                _wv.updateProducts(_fm.FileContent);
            }

            else
            {
                _wv.getErrorMessage("ArtNr must constist of 6 numbers");
            }
            }
        }
    }

