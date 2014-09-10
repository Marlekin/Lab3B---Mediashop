using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace MediaShop
{
    public class CashierView : Panel
    {
        //Variables
        private CashierController cc;

        private Panel productsPanel;
        private Label productsLabel;
        private RichTextBox products;
        private Panel cartPanel;
        private Panel addPanel;
        private Label shoppingCartLabel;
        private Label priceSumLabel;
        private RichTextBox shoppingCart;
        private Label artNrLabel;
        private TextBox artNr;
        private Button searchButton;
        private Button returnButton;
        private Button purchaseButton;
        private Button removeButton;
        private Button addButton;
        private Label amountLabel;
        private TextBox amount;

        //----------For the search dialog---------//
        private Form searchDialog;
        private Label artNrSearchLabel;
        private Label nameSearchLabel;
        private TextBox artNrSearch;
        private TextBox nameSearch;
        private Label uniqueSearchLabel;
        private TextBox uniqueSearch;
        private RichTextBox results;
        private Button search;
        private Label searchInfoLabel;
        //---------------------------------------//

        //Constructor, calls all the methods for building the view
        public CashierView(FileManager fm)
        {
            cc = new CashierController(this, fm);

            createControls();
            initializeControls();
            setEventHandler();
            getInputBox();
            searchDialog.Hide();
            this.Width = 750;
            this.Height = 419;
        }

        //Instantiation of controls
        private void createControls()
        {

            this.productsPanel = new System.Windows.Forms.Panel();
            this.productsLabel = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.RichTextBox();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.artNrLabel = new System.Windows.Forms.Label();
            this.artNr = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCart = new System.Windows.Forms.RichTextBox();
            this.priceSumLabel = new System.Windows.Forms.Label();


        }
        //Initialization of controls
        public void initializeControls()
        {


            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            this.cartPanel.ResumeLayout(false);
            this.cartPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();

            this.productsPanel.SuspendLayout();
            this.cartPanel.SuspendLayout();
            this.addPanel.SuspendLayout();

            this.Controls.Add(this.cartPanel);
            this.Controls.Add(this.productsPanel);

            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.productsLabel);
            this.productsPanel.Controls.Add(this.products);
            this.productsPanel.Location = new System.Drawing.Point(352, 0);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(399, 419);
            this.productsPanel.TabIndex = 5;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(16, 6);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(234, 13);
            this.productsLabel.TabIndex = 3;
            this.productsLabel.Text = "Products: (TYPE: ArtNr . Name . Price . Descriptiom . Amount)";
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.LavenderBlush;
            this.products.Location = new System.Drawing.Point(19, 25);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(362, 388);
            this.products.TabIndex = 0;
            this.products.Text = "";
            // 
            // cartPanel
            // 
            this.cartPanel.Controls.Add(this.addPanel);
            this.cartPanel.Controls.Add(this.shoppingCartLabel);
            this.cartPanel.Controls.Add(this.priceSumLabel);
            this.cartPanel.Controls.Add(this.shoppingCart);
            this.cartPanel.Location = new System.Drawing.Point(0, 0);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(353, 419);
            this.cartPanel.TabIndex = 4;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.addPanel.Controls.Add(this.artNrLabel);
            this.addPanel.Controls.Add(this.artNr);
            this.addPanel.Controls.Add(this.searchButton);
            this.addPanel.Controls.Add(this.purchaseButton);
            this.addPanel.Controls.Add(this.returnButton);
            this.addPanel.Controls.Add(this.removeButton);
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.amount);
            this.addPanel.Controls.Add(this.amountLabel);
            this.addPanel.Location = new System.Drawing.Point(26, 299);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(303, 114);
            this.addPanel.TabIndex = 3;
            // 
            // artNrLabel
            // 
            this.artNrLabel.AutoSize = true;
            this.artNrLabel.Location = new System.Drawing.Point(14, 8);
            this.artNrLabel.Name = "artNrLabel";
            this.artNrLabel.Size = new System.Drawing.Size(165, 13);
            this.artNrLabel.TabIndex = 6;
            this.artNrLabel.Text = "ArtNr: (6 digits, not starting with 0)";
            // 
            // artNr
            // 
            this.artNr.Location = new System.Drawing.Point(17, 23);
            this.artNr.Name = "artNr";
            this.artNr.Size = new System.Drawing.Size(156, 20);
            this.artNr.TabIndex = 5;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(14, 45);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(165, 13);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount:";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(17, 60);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(50, 20);
            this.amount.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(201, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search product";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(201, 78);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(89, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return product";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(201, 20);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(89, 23);
            this.purchaseButton.TabIndex = 2;
            this.purchaseButton.Text = "Make purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(98, 85);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(17, 85);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Location = new System.Drawing.Point(25, 7);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(73, 13);
            this.shoppingCartLabel.TabIndex = 2;
            this.shoppingCartLabel.Text = "Shoppingcart:";
            // 
            // shoppingCart
            // 
            this.shoppingCart.Location = new System.Drawing.Point(25, 26);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(305, 267);
            this.shoppingCart.TabIndex = 1;
            this.shoppingCart.Text = "";
            //
            // priceSumLabel
            //
            this.priceSumLabel.AutoSize = true;
            this.priceSumLabel.Location = new System.Drawing.Point(160, 7);
            this.priceSumLabel.Name = "priceSumLabel";
            this.priceSumLabel.Size = new System.Drawing.Size(73, 13);
            this.priceSumLabel.TabIndex = 2;
            this.priceSumLabel.Text = "Sumtotal: " + 0;


        }
        //Adds eventhandlers to buttons
        public void setEventHandler()
        {
            addButton.Click += new EventHandler(cc.addClick);
            removeButton.Click += new EventHandler(cc.removeClick);
            purchaseButton.Click += new EventHandler(cc.purchaseClick);
            returnButton.Click += new EventHandler(cc.returnClick);
            searchButton.Click += new EventHandler(cc.openSearchClick);


        }

        //Fetches artnr from textbox. Checks that it consists of all numbers 
        //and that the value is not too high
        public int getartNr()
        {
            if (artNr.Text != "")
            {
                try
                {
                    int art = Convert.ToInt32(artNr.Text);

                    return art;
                }
                catch (FormatException e)
                {
                    getErrorMessage("ArtNr must consist of all numbers");
                }
                catch (OverflowException e)
                {
                    getErrorMessage("The value of ArtNr, is too damn high");
                }
            }

            return 0;
        }

        //Fetches amount from textbox. Checks that it consists of all numbers 
        //and that the value is not too high
        public int getAmount()
        {
            if (amount.Text != "")
            {
                try
                {
                    int am = Convert.ToInt32(amount.Text);

                    return am;
                }
                catch (FormatException e)
                {
                    getErrorMessage("Amount must consist of all numbers");
                }
                catch (OverflowException e)
                {
                    getErrorMessage("The value of amount, is too damn high");
                }
            }
            return 0;
        }

        //Fetches label for the total sum(priceSumLabel)
        public Label getPriceLabel()
        {
            return priceSumLabel;
        }

        //Fetches a string with the contents of the shoppingcart
        public String getCartContent()
        {
            return shoppingCart.Text;
        }

        //Fetches and Messagebox for the controller to use for alerts and warnings
        public void getErrorMessage(String s)
        {
            MessageBox.Show(s);
        }

        //Creates the search dialog
        public Form getInputBox()
        {


            searchDialog = new Form();
            searchDialog.Text = "Search";
            searchDialog.FormBorderStyle = FormBorderStyle.FixedSingle;
            searchDialog.SuspendLayout();
            searchDialog.Width = 520;
            searchDialog.Height = 320;
            searchDialog.FormClosing += new FormClosingEventHandler(cc.closeSearch);
            searchDialog.TopMost = true;

            artNrSearchLabel = new Label();
            artNrSearchLabel.Text = "ArtNr: ";
            artNrSearchLabel.Size = new System.Drawing.Size(50, 13);
            artNrSearch = new TextBox();
            artNrSearch.Location = new System.Drawing.Point(10, 30);
            artNrSearchLabel.Location = new System.Drawing.Point(10, 10);

            searchInfoLabel = new Label();
            searchInfoLabel.Text = "(To avoid duplicate results, only use one field at a time)";
            searchInfoLabel.Size = new System.Drawing.Size(500, 13);
            searchInfoLabel.Location = new System.Drawing.Point(10, 270);

            nameSearchLabel = new Label();
            nameSearchLabel.Text = "Name: ";
            nameSearchLabel.Size = new System.Drawing.Size(50, 13);
            nameSearch = new TextBox();
            nameSearch.Location = new System.Drawing.Point(125, 30);
            nameSearchLabel.Location = new System.Drawing.Point(125, 10);


            uniqueSearchLabel = new Label();
            uniqueSearchLabel.Text = "Author/Artist/Director/Producer: ";
            uniqueSearchLabel.Size = new System.Drawing.Size(165, 13);
            uniqueSearch = new TextBox();
            uniqueSearch.Width = 165;
            uniqueSearch.Location = new System.Drawing.Point(240, 30);
            uniqueSearchLabel.Location = new System.Drawing.Point(240, 10);


            search = new Button();
            search.Text = "Search";
            search.Location = new System.Drawing.Point(420, 15);
            search.Height = 35;
            search.Click += new EventHandler(cc.searchClick);

            results = new RichTextBox();
            results.Location = new System.Drawing.Point(10, 60);
            results.Width = 400;
            results.Height = 200;


            searchDialog.Controls.Add(nameSearchLabel);
            searchDialog.Controls.Add(nameSearch);
            searchDialog.Controls.Add(uniqueSearchLabel);
            searchDialog.Controls.Add(uniqueSearch);
            searchDialog.Controls.Add(search);
            searchDialog.Controls.Add(artNrSearch);
            searchDialog.Controls.Add(artNrSearchLabel);
            searchDialog.Controls.Add(results);
            searchDialog.Controls.Add(searchInfoLabel);

            return searchDialog;
        }

        //Hides the search dialog
        public void hideSearch()
        {

            searchDialog.Hide();

        }

        //Shows the search dialog
        public void showSearch()
        {
            searchDialog.Show();
        }

        //Gets the artnr from the search dialog textbox
        public String getArtnrSearch()
        {
            return artNrSearch.Text;
        }

        //Gets the name from the search dialog textbox
        public String getNameSearch()
        {
            return nameSearch.Text;
        }

        //Gets the Author/Artist/Director/Producer from the search dialog textbox
        public string getUniqueSearch()
        {
            return uniqueSearch.Text;
        }

        //Updates the list of products
        public void updateProducts(String s)
        {
            products.Text = s;
        }

        //Updates the shoppingvart list
        public void updateCart(String s)
        {
            shoppingCart.Text = s;
        }

        //Updates search results in the search dialog
        public void updateResults(String s)
        {
            results.Text = s;
        }

    }
}
