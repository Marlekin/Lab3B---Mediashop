using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace MediaShop
{
    public class WarehouseView: Panel
    {

        //Variables
        private WarehouseController wc;

        private Button addButton;
        private Label addLabel;
        private RichTextBox Productbox;
        private Button removeOk;
        private Label deliveryAmountLabel;
        private TextBox deliveryAmount;
        private Label productlabel;
        private Button deliveryOk;
        private TextBox removeArtNr;
        private Label removeArtNrLabel;
        private TextBox deliveryArtNr;
        private Label deliveryArtNrLabel;
        private Panel addProductsPanel;
        private Panel productsPanel;
        private Panel removePanel;
        private Panel deliveryPanel;
        private Label removeLabel;
        private Label deliveryLabel;
        private TabControl addTabs;
        private TabPage booktab;
        private Label bookgameAmountLabel;
        private TextBox bookAmount;
        private TextBox bookName;
        private TextBox bookPrice;
        private TextBox bookAuthor;
        private TextBox bookArtNr;
        private Label bookAuthorLabel;
        private Label bookPricelabel;
        private Label bookNameLabel;
        private Label bookArtNrLabel;
        private TabPage cdTab;
        private Label cdAmountLabel;
        private TextBox cdAmount;
        private TextBox cdName;
        private TextBox cdPrice;
        private TextBox cdArtist;
        private TextBox cdArtNr;
        private Label cdArtistLabel;
        private Label cdPriceLabel;
        private Label cdNameLabel;
        private Label cdArtNrLabel;
        private TabPage dvdTab;
        private Label dvdAmountLabel;
        private TextBox dvdAmount;
        private TextBox dvdName;
        private TextBox dvdPrice;
        private TextBox dvdDirector;
        private TextBox dvdArtNr;
        private Label dvdDirectorLabel;
        private Label dvdPriceLabel;
        private Label dvdNameLabel;
        private Label dvdArtNrLabel;
        private TabPage gameTab;
        private Label gameAmountLabel;
        private TextBox gameAmount;
        private TextBox gameName;
        private TextBox gamePrice;
        private TextBox gameProducer;
        private TextBox gameArtNr;
        private Label gameProdLabel;
        private Label gamePriceLabel;
        private Label gameNameLabel;
        private Label gameArtNrLabel; 

        //Constructor
        public WarehouseView(FileManager fm)
        {
            wc = new WarehouseController(this, fm);

            createControls();
            initializeControls();
            setEventHandler();

            this.Width = 751;
            this.Height = 419;

        }

        //Instansiates controls
        public void createControls(){
               
            deliveryArtNr = new System.Windows.Forms.TextBox();
            deliveryArtNrLabel = new System.Windows.Forms.Label();
            removeArtNr = new System.Windows.Forms.TextBox();
            removeArtNrLabel = new System.Windows.Forms.Label();
            deliveryOk = new System.Windows.Forms.Button();
            deliveryAmountLabel = new System.Windows.Forms.Label();
            deliveryAmount = new System.Windows.Forms.TextBox();
            productlabel = new System.Windows.Forms.Label();
            removeOk = new System.Windows.Forms.Button();
            Productbox = new System.Windows.Forms.RichTextBox();
            addButton = new System.Windows.Forms.Button();
            addLabel = new System.Windows.Forms.Label();
            productsPanel = new System.Windows.Forms.Panel();
            addProductsPanel = new System.Windows.Forms.Panel();
            deliveryPanel = new System.Windows.Forms.Panel();
            removePanel = new System.Windows.Forms.Panel();
            deliveryLabel = new System.Windows.Forms.Label();
            removeLabel = new System.Windows.Forms.Label();
            gameTab = new System.Windows.Forms.TabPage();
            gameArtNr = new System.Windows.Forms.TextBox();
            gameProducer = new System.Windows.Forms.TextBox();
            gamePrice = new System.Windows.Forms.TextBox();
            gameName = new System.Windows.Forms.TextBox();
            gameArtNrLabel = new System.Windows.Forms.Label();
            gameNameLabel = new System.Windows.Forms.Label();
            gamePriceLabel = new System.Windows.Forms.Label();
            gameProdLabel = new System.Windows.Forms.Label();
            gameAmount = new System.Windows.Forms.TextBox();
            gameAmountLabel = new System.Windows.Forms.Label();
            dvdTab = new System.Windows.Forms.TabPage();
            dvdArtNr = new System.Windows.Forms.TextBox();
            dvdDirector = new System.Windows.Forms.TextBox();
            dvdPrice = new System.Windows.Forms.TextBox();
            dvdName = new System.Windows.Forms.TextBox();
            dvdArtNrLabel = new System.Windows.Forms.Label();
            dvdNameLabel = new System.Windows.Forms.Label();
            dvdPriceLabel = new System.Windows.Forms.Label();
            dvdDirectorLabel = new System.Windows.Forms.Label();
            dvdAmount = new System.Windows.Forms.TextBox();
            dvdAmountLabel = new System.Windows.Forms.Label();
            cdTab = new System.Windows.Forms.TabPage();
            cdArtNr = new System.Windows.Forms.TextBox();
            cdArtist = new System.Windows.Forms.TextBox();
            cdPrice = new System.Windows.Forms.TextBox();
            cdName = new System.Windows.Forms.TextBox();
            cdArtNrLabel = new System.Windows.Forms.Label();
            cdNameLabel = new System.Windows.Forms.Label();
            cdPriceLabel = new System.Windows.Forms.Label();
            cdArtistLabel = new System.Windows.Forms.Label();
            cdAmount = new System.Windows.Forms.TextBox();
            cdAmountLabel = new System.Windows.Forms.Label();
            booktab = new System.Windows.Forms.TabPage();
            bookArtNr = new System.Windows.Forms.TextBox();
            bookAuthor = new System.Windows.Forms.TextBox();
            bookPrice = new System.Windows.Forms.TextBox();
            bookName = new System.Windows.Forms.TextBox();
            bookArtNrLabel = new System.Windows.Forms.Label();
            bookNameLabel = new System.Windows.Forms.Label();
            bookPricelabel = new System.Windows.Forms.Label();
            bookAuthorLabel = new System.Windows.Forms.Label();
            bookAmount = new System.Windows.Forms.TextBox();
            bookgameAmountLabel = new System.Windows.Forms.Label();
            addTabs = new System.Windows.Forms.TabControl();
        }
        //Initializes controls
        public void initializeControls()
        {

            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            this.addProductsPanel.ResumeLayout(false);
            this.addProductsPanel.PerformLayout();
            this.deliveryPanel.ResumeLayout(false);
            this.deliveryPanel.PerformLayout();
            this.removePanel.ResumeLayout(false);
            this.removePanel.PerformLayout();
            this.gameTab.ResumeLayout(false);
            this.gameTab.PerformLayout();
            this.dvdTab.ResumeLayout(false);
            this.dvdTab.PerformLayout();
            this.cdTab.ResumeLayout(false);
            this.cdTab.PerformLayout();
            this.booktab.ResumeLayout(false);
            this.booktab.PerformLayout();
            this.addTabs.ResumeLayout(false);


            this.productsPanel.SuspendLayout();
            this.addProductsPanel.SuspendLayout();
            this.deliveryPanel.SuspendLayout();
            this.removePanel.SuspendLayout();
            this.gameTab.SuspendLayout();
            this.dvdTab.SuspendLayout();
            this.cdTab.SuspendLayout();
            this.booktab.SuspendLayout();
            this.addTabs.SuspendLayout();

            this.Controls.Add(this.addProductsPanel);
            this.Controls.Add(this.productsPanel);
            // 
            // deliveryArtNr
            // 
            this.deliveryArtNr.Location = new System.Drawing.Point(32, 46);
            this.deliveryArtNr.Name = "deliveryArtNr";
            this.deliveryArtNr.Size = new System.Drawing.Size(139, 20);
            this.deliveryArtNr.TabIndex = 12;
            // 
            // deliveryArtNrLabel
            // 
            this.deliveryArtNrLabel.AutoSize = true;
            this.deliveryArtNrLabel.Location = new System.Drawing.Point(29, 23);
            this.deliveryArtNrLabel.Name = "deliveryArtNrLabel";
            this.deliveryArtNrLabel.Size = new System.Drawing.Size(34, 13);
            this.deliveryArtNrLabel.TabIndex = 11;
            this.deliveryArtNrLabel.Text = "ArtNr:";
            // 
            // removeArtNr
            // 
            this.removeArtNr.Location = new System.Drawing.Point(36, 44);
            this.removeArtNr.Name = "removeArtNr";
            this.removeArtNr.Size = new System.Drawing.Size(124, 20);
            this.removeArtNr.TabIndex = 10;
            // 
            // removeArtNrLabel
            // 
            this.removeArtNrLabel.AutoSize = true;
            this.removeArtNrLabel.Location = new System.Drawing.Point(33, 21);
            this.removeArtNrLabel.Name = "removeArtNrLabel";
            this.removeArtNrLabel.Size = new System.Drawing.Size(34, 13);
            this.removeArtNrLabel.TabIndex = 9;
            this.removeArtNrLabel.Text = "ArtNr: ";
            // 
            // deliveryOk
            // 
            this.deliveryOk.BackColor = System.Drawing.SystemColors.Control;
            this.deliveryOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deliveryOk.Location = new System.Drawing.Point(81, 79);
            this.deliveryOk.Name = "deliveryOk";
            this.deliveryOk.Size = new System.Drawing.Size(90, 43);
            this.deliveryOk.TabIndex = 8;
            this.deliveryOk.Text = "Ok";
            this.deliveryOk.UseVisualStyleBackColor = false;
            // 
            // deliveryAmountLabel
            // 
            this.deliveryAmountLabel.AutoSize = true;
            this.deliveryAmountLabel.Location = new System.Drawing.Point(29, 79);
            this.deliveryAmountLabel.Name = "deliveryAmountLabel";
            this.deliveryAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.deliveryAmountLabel.TabIndex = 7;
            this.deliveryAmountLabel.Text = "Amount:";
            // 
            // deliveryAmount
            // 
            this.deliveryAmount.Location = new System.Drawing.Point(32, 102);
            this.deliveryAmount.Name = "deliveryAmount";
            this.deliveryAmount.Size = new System.Drawing.Size(43, 20);
            this.deliveryAmount.TabIndex = 6;
            // 
            // productlabel
            // 
            this.productlabel.AutoSize = true;
            this.productlabel.Location = new System.Drawing.Point(10, 9);
            this.productlabel.Name = "productlabel";
            this.productlabel.Size = new System.Drawing.Size(52, 13);
            this.productlabel.TabIndex = 5;
            this.productlabel.Text = "Products: (TYPE: ArtNr . Name . Price . Description . Amount)";
            // 
            // removeOk
            // 
            this.removeOk.BackColor = System.Drawing.SystemColors.Control;
            this.removeOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removeOk.Location = new System.Drawing.Point(69, 77);
            this.removeOk.Name = "removeOk";
            this.removeOk.Size = new System.Drawing.Size(60, 43);
            this.removeOk.TabIndex = 4;
            this.removeOk.Text = "Remove";
            this.removeOk.UseVisualStyleBackColor = false;
            // 
            // Productbox
            // 
            this.Productbox.BackColor = System.Drawing.Color.LavenderBlush;
            this.Productbox.Location = new System.Drawing.Point(13, 25);
            this.Productbox.Name = "Productbox";
            this.Productbox.Size = new System.Drawing.Size(417, 231);
            this.Productbox.TabIndex = 3;
            this.Productbox.Text = "";
            this.Productbox.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LawnGreen;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(234, 317);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 47);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add ->";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(19, 7);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(68, 13);
            this.addLabel.TabIndex = 1;
            this.addLabel.Text = "Add product:";
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.removeLabel);
            this.productsPanel.Controls.Add(this.deliveryLabel);
            this.productsPanel.Controls.Add(this.removePanel);
            this.productsPanel.Controls.Add(this.deliveryPanel);
            this.productsPanel.Controls.Add(this.productlabel);
            this.productsPanel.Controls.Add(this.Productbox);
            this.productsPanel.Location = new System.Drawing.Point(298, 1);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(452, 417);
            this.productsPanel.TabIndex = 13;
            // 
            // addProductsPanel
            // 
            this.addProductsPanel.Controls.Add(this.addButton);
            this.addProductsPanel.Controls.Add(this.addLabel);
            this.addProductsPanel.Controls.Add(this.addTabs);
            this.addProductsPanel.Location = new System.Drawing.Point(0, 0);
            this.addProductsPanel.Name = "addProductsPanel";
            this.addProductsPanel.Size = new System.Drawing.Size(302, 418);
            this.addProductsPanel.TabIndex = 14;
            // 
            // deliveryPanel
            // 
            this.deliveryPanel.BackColor = System.Drawing.Color.LightGreen;
            this.deliveryPanel.Controls.Add(this.deliveryArtNr);
            this.deliveryPanel.Controls.Add(this.deliveryArtNrLabel);
            this.deliveryPanel.Controls.Add(this.deliveryOk);
            this.deliveryPanel.Controls.Add(this.deliveryAmountLabel);
            this.deliveryPanel.Controls.Add(this.deliveryAmount);
            this.deliveryPanel.Location = new System.Drawing.Point(19, 267);
            this.deliveryPanel.Name = "deliveryPanel";
            this.deliveryPanel.Size = new System.Drawing.Size(195, 137);
            this.deliveryPanel.TabIndex = 13;
            // 
            // removePanel
            // 
            this.removePanel.BackColor = System.Drawing.Color.Tomato;
            this.removePanel.Controls.Add(this.removeArtNr);
            this.removePanel.Controls.Add(this.removeArtNrLabel);
            this.removePanel.Controls.Add(this.removeOk);
            this.removePanel.Location = new System.Drawing.Point(234, 269);
            this.removePanel.Name = "removePanel";
            this.removePanel.Size = new System.Drawing.Size(195, 134);
            this.removePanel.TabIndex = 14;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.deliveryLabel.Location = new System.Drawing.Point(11, 263);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(48, 13);
            this.deliveryLabel.TabIndex = 15;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.BackColor = System.Drawing.Color.Red;
            this.removeLabel.Location = new System.Drawing.Point(221, 262);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(50, 13);
            this.removeLabel.TabIndex = 16;
            this.removeLabel.Text = "Remove:";
            // 
            // gameTab
            // 
            this.gameTab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gameTab.Controls.Add(this.gameAmountLabel);
            this.gameTab.Controls.Add(this.gameAmount);
            this.gameTab.Controls.Add(this.gameName);
            this.gameTab.Controls.Add(this.gamePrice);
            this.gameTab.Controls.Add(this.gameProducer);
            this.gameTab.Controls.Add(this.gameArtNr);
            this.gameTab.Controls.Add(this.gameProdLabel);
            this.gameTab.Controls.Add(this.gamePriceLabel);
            this.gameTab.Controls.Add(this.gameNameLabel);
            this.gameTab.Controls.Add(this.gameArtNrLabel);
            this.gameTab.Location = new System.Drawing.Point(4, 22);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(243, 303);
            this.gameTab.TabIndex = 3;
            this.gameTab.Text = "Game";
            // 
            // gameArtNr
            // 
            this.gameArtNr.Location = new System.Drawing.Point(6, 31);
            this.gameArtNr.Name = "gameArtNr";
            this.gameArtNr.Size = new System.Drawing.Size(220, 20);
            this.gameArtNr.TabIndex = 8;
            // 
            // gameProducer
            // 
            this.gameProducer.Location = new System.Drawing.Point(6, 189);
            this.gameProducer.Name = "gameProducer";
            this.gameProducer.Size = new System.Drawing.Size(220, 20);
            this.gameProducer.TabIndex = 9;
            // 
            // gamePrice
            // 
            this.gamePrice.Location = new System.Drawing.Point(6, 135);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(220, 20);
            this.gamePrice.TabIndex = 10;
            // 
            // gameName
            // 
            this.gameName.Location = new System.Drawing.Point(6, 82);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(220, 20);
            this.gameName.TabIndex = 11;
            // 
            // gameArtNrLabel
            // 
            this.gameArtNrLabel.AutoSize = true;
            this.gameArtNrLabel.Location = new System.Drawing.Point(6, 12);
            this.gameArtNrLabel.Name = "gameArtNrLabel";
            this.gameArtNrLabel.Size = new System.Drawing.Size(34, 13);
            this.gameArtNrLabel.TabIndex = 12;
            this.gameArtNrLabel.Text = "ArtNr: (6 digits, not starting with 0)";
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Location = new System.Drawing.Point(6, 66);
            this.gameNameLabel.Name = "gameName";
            this.gameNameLabel.Size = new System.Drawing.Size(38, 13);
            this.gameNameLabel.TabIndex = 13;
            this.gameNameLabel.Text = "Name: (Letters)";
            // 
            // gamePriceLabel
            // 
            this.gamePriceLabel.AutoSize = true;
            this.gamePriceLabel.Location = new System.Drawing.Point(6, 119);
            this.gamePriceLabel.Name = "gamePriceLabel";
            this.gamePriceLabel.Size = new System.Drawing.Size(34, 13);
            this.gamePriceLabel.TabIndex = 14;
            this.gamePriceLabel.Text = "Price: (Numbers, decimals allowed)";
            // 
            // gameProdLabel
            // 
            this.gameProdLabel.AutoSize = true;
            this.gameProdLabel.Location = new System.Drawing.Point(6, 173);
            this.gameProdLabel.Name = "gameProdLabel";
            this.gameProdLabel.Size = new System.Drawing.Size(53, 13);
            this.gameProdLabel.TabIndex = 15;
            this.gameProdLabel.Text = "Producer: (Letters)";
            // 
            // gameAmount
            // 
            this.gameAmount.Location = new System.Drawing.Point(6, 243);
            this.gameAmount.Name = "gameAmount";
            this.gameAmount.Size = new System.Drawing.Size(59, 20);
            this.gameAmount.TabIndex = 16;
            // 
            // gameAmountLabel
            // 
            this.gameAmountLabel.AutoSize = true;
            this.gameAmountLabel.Location = new System.Drawing.Point(6, 227);
            this.gameAmountLabel.Name = "gameAmountLabel";
            this.gameAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.gameAmountLabel.TabIndex = 17;
            this.gameAmountLabel.Text = "Amount: (Numbers, 0 to 99999)";
            // 
            // dvdTab
            // 
            this.dvdTab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dvdTab.Controls.Add(this.dvdAmountLabel);
            this.dvdTab.Controls.Add(this.dvdAmount);
            this.dvdTab.Controls.Add(this.dvdName);
            this.dvdTab.Controls.Add(this.dvdPrice);
            this.dvdTab.Controls.Add(this.dvdDirector);
            this.dvdTab.Controls.Add(this.dvdArtNr);
            this.dvdTab.Controls.Add(this.dvdDirectorLabel);
            this.dvdTab.Controls.Add(this.dvdPriceLabel);
            this.dvdTab.Controls.Add(this.dvdNameLabel);
            this.dvdTab.Controls.Add(this.dvdArtNrLabel);
            this.dvdTab.Location = new System.Drawing.Point(4, 22);
            this.dvdTab.Name = "dvdTab";
            this.dvdTab.Padding = new System.Windows.Forms.Padding(3);
            this.dvdTab.Size = new System.Drawing.Size(243, 303);
            this.dvdTab.TabIndex = 2;
            this.dvdTab.Text = "Dvd";
            // 
            // dvdArtNr
            // 
            this.dvdArtNr.Location = new System.Drawing.Point(6, 31);
            this.dvdArtNr.Name = "dvdArtNr";
            this.dvdArtNr.Size = new System.Drawing.Size(220, 20);
            this.dvdArtNr.TabIndex = 8;
            // 
            // dvdDirector
            // 
            this.dvdDirector.Location = new System.Drawing.Point(6, 189);
            this.dvdDirector.Name = "dvdDirector";
            this.dvdDirector.Size = new System.Drawing.Size(220, 20);
            this.dvdDirector.TabIndex = 9;
            // 
            // dvdPrice
            // 
            this.dvdPrice.Location = new System.Drawing.Point(6, 135);
            this.dvdPrice.Name = "dvdPrice";
            this.dvdPrice.Size = new System.Drawing.Size(220, 20);
            this.dvdPrice.TabIndex = 10;
            // 
            // dvdName
            // 
            this.dvdName.Location = new System.Drawing.Point(6, 82);
            this.dvdName.Name = "dvdName";
            this.dvdName.Size = new System.Drawing.Size(220, 20);
            this.dvdName.TabIndex = 11;
            // 
            // dvdArtNrLabel
            // 
            this.dvdArtNrLabel.AutoSize = true;
            this.dvdArtNrLabel.Location = new System.Drawing.Point(6, 12);
            this.dvdArtNrLabel.Name = "dvdArtNrLabel";
            this.dvdArtNrLabel.Size = new System.Drawing.Size(34, 13);
            this.dvdArtNrLabel.TabIndex = 12;
            this.dvdArtNrLabel.Text = "ArtNr: (6 digits, not starting with 0)";
            // 
            // dvdNameLabel
            // 
            this.dvdNameLabel.AutoSize = true;
            this.dvdNameLabel.Location = new System.Drawing.Point(6, 66);
            this.dvdNameLabel.Name = "dvdNameLabel";
            this.dvdNameLabel.Size = new System.Drawing.Size(38, 13);
            this.dvdNameLabel.TabIndex = 13;
            this.dvdNameLabel.Text = "Name: (Letters)";
            // 
            // dvdPriceLabel
            // 
            this.dvdPriceLabel.AutoSize = true;
            this.dvdPriceLabel.Location = new System.Drawing.Point(6, 119);
            this.dvdPriceLabel.Name = "dvdPriceLabel";
            this.dvdPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.dvdPriceLabel.TabIndex = 14;
            this.dvdPriceLabel.Text = "Price: (Numbers, decimals allowed)";
            // 
            // dvdDirectorLabel
            // 
            this.dvdDirectorLabel.AutoSize = true;
            this.dvdDirectorLabel.Location = new System.Drawing.Point(6, 173);
            this.dvdDirectorLabel.Name = "dvdDirectorLabel";
            this.dvdDirectorLabel.Size = new System.Drawing.Size(47, 13);
            this.dvdDirectorLabel.TabIndex = 15;
            this.dvdDirectorLabel.Text = "Director: (Letters)";
            // 
            // dvdAmount
            // 
            this.dvdAmount.Location = new System.Drawing.Point(6, 243);
            this.dvdAmount.Name = "dvdAmount";
            this.dvdAmount.Size = new System.Drawing.Size(59, 20);
            this.dvdAmount.TabIndex = 18;
            // 
            // dvdAmountLabel
            // 
            this.dvdAmountLabel.AutoSize = true;
            this.dvdAmountLabel.Location = new System.Drawing.Point(6, 227);
            this.dvdAmountLabel.Name = "dvdAmountLabel";
            this.dvdAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.dvdAmountLabel.TabIndex = 19;
            this.dvdAmountLabel.Text = "Amount: (Numbers, 0 to 99999) ";
            // 
            // cdTab
            // 
            this.cdTab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cdTab.Controls.Add(this.cdAmountLabel);
            this.cdTab.Controls.Add(this.cdAmount);
            this.cdTab.Controls.Add(this.cdName);
            this.cdTab.Controls.Add(this.cdPrice);
            this.cdTab.Controls.Add(this.cdArtist);
            this.cdTab.Controls.Add(this.cdArtNr);
            this.cdTab.Controls.Add(this.cdArtistLabel);
            this.cdTab.Controls.Add(this.cdPriceLabel);
            this.cdTab.Controls.Add(this.cdNameLabel);
            this.cdTab.Controls.Add(this.cdArtNrLabel);
            this.cdTab.Location = new System.Drawing.Point(4, 22);
            this.cdTab.Name = "cdTab";
            this.cdTab.Padding = new System.Windows.Forms.Padding(3);
            this.cdTab.Size = new System.Drawing.Size(243, 303);
            this.cdTab.TabIndex = 1;
            this.cdTab.Text = "Cd";
            // 
            // cdArtNr
            // 
            this.cdArtNr.Location = new System.Drawing.Point(6, 31);
            this.cdArtNr.Name = "cdArtNr";
            this.cdArtNr.Size = new System.Drawing.Size(220, 20);
            this.cdArtNr.TabIndex = 8;
            // 
            // cdArtist
            // 
            this.cdArtist.Location = new System.Drawing.Point(6, 189);
            this.cdArtist.Name = "cdPrice";
            this.cdArtist.Size = new System.Drawing.Size(220, 20);
            this.cdArtist.TabIndex = 9;
            // 
            // cdPrice
            // 
            this.cdPrice.Location = new System.Drawing.Point(6, 135);
            this.cdPrice.Name = "cdName";
            this.cdPrice.Size = new System.Drawing.Size(220, 20);
            this.cdPrice.TabIndex = 10;
            // 
            // cdName
            // 
            this.cdName.Location = new System.Drawing.Point(6, 82);
            this.cdName.Name = "cdArtNr";
            this.cdName.Size = new System.Drawing.Size(220, 20);
            this.cdName.TabIndex = 11;
            // 
            // cdArtNrLabel
            // 
            this.cdArtNrLabel.AutoSize = true;
            this.cdArtNrLabel.Location = new System.Drawing.Point(6, 12);
            this.cdArtNrLabel.Name = "cdArtNrLabel";
            this.cdArtNrLabel.Size = new System.Drawing.Size(34, 13);
            this.cdArtNrLabel.TabIndex = 12;
            this.cdArtNrLabel.Text = "ArtNr: (6 digits, not starting with 0)";
            // 
            // cdNameLabel
            // 
            this.cdNameLabel.AutoSize = true;
            this.cdNameLabel.Location = new System.Drawing.Point(6, 66);
            this.cdNameLabel.Name = "cdNameLabel";
            this.cdNameLabel.Size = new System.Drawing.Size(38, 13);
            this.cdNameLabel.TabIndex = 13;
            this.cdNameLabel.Text = "Name: (Letters)";
            // 
            // cdPriceLabel
            // 
            this.cdPriceLabel.AutoSize = true;
            this.cdPriceLabel.Location = new System.Drawing.Point(6, 119);
            this.cdPriceLabel.Name = "cdPriceLabel";
            this.cdPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.cdPriceLabel.TabIndex = 14;
            this.cdPriceLabel.Text = "Price: (Numbers, decimals allowed)";
            // 
            // cdArtistLabel
            // 
            this.cdArtistLabel.AutoSize = true;
            this.cdArtistLabel.Location = new System.Drawing.Point(6, 173);
            this.cdArtistLabel.Name = "cdArtistLabel";
            this.cdArtistLabel.Size = new System.Drawing.Size(33, 13);
            this.cdArtistLabel.TabIndex = 15;
            this.cdArtistLabel.Text = "Artist: (Letters)";
            // 
            // cdAmount
            // 
            this.cdAmount.Location = new System.Drawing.Point(6, 243);
            this.cdAmount.Name = "cdAmount";
            this.cdAmount.Size = new System.Drawing.Size(59, 20);
            this.cdAmount.TabIndex = 20;
            // 
            // cdAmountLabel
            // 
            this.cdAmountLabel.AutoSize = true;
            this.cdAmountLabel.Location = new System.Drawing.Point(6, 227);
            this.cdAmountLabel.Name = "cdAmountLabel";
            this.cdAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.cdAmountLabel.TabIndex = 21;
            this.cdAmountLabel.Text = "Amount: (Numbers, 0 to 99999) ";
            // 
            // booktab
            // 
            this.booktab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.booktab.Controls.Add(this.bookgameAmountLabel);
            this.booktab.Controls.Add(this.bookAmount);
            this.booktab.Controls.Add(this.bookName);
            this.booktab.Controls.Add(this.bookPrice);
            this.booktab.Controls.Add(this.bookAuthor);
            this.booktab.Controls.Add(this.bookArtNr);
            this.booktab.Controls.Add(this.bookAuthorLabel);
            this.booktab.Controls.Add(this.bookPricelabel);
            this.booktab.Controls.Add(this.bookNameLabel);
            this.booktab.Controls.Add(this.bookArtNrLabel);
            this.booktab.Location = new System.Drawing.Point(4, 22);
            this.booktab.Name = "booktab";
            this.booktab.Padding = new System.Windows.Forms.Padding(3);
            this.booktab.Size = new System.Drawing.Size(243, 303);
            this.booktab.TabIndex = 0;
            this.booktab.Text = "Book";
            // 
            // bookArtNr
            // 
            this.bookArtNr.Location = new System.Drawing.Point(6, 31);
            this.bookArtNr.Name = "bookArtNr";
            this.bookArtNr.Size = new System.Drawing.Size(220, 20);
            this.bookArtNr.TabIndex = 0;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Location = new System.Drawing.Point(6, 189);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(220, 20);
            this.bookAuthor.TabIndex = 1;
            // 
            // bookPrice
            // 
            this.bookPrice.Location = new System.Drawing.Point(6, 135);
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.Size = new System.Drawing.Size(220, 20);
            this.bookPrice.TabIndex = 2;
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(6, 82);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(220, 20);
            this.bookName.TabIndex = 3;
            // 
            // bookArtNrLabel
            // 
            this.bookArtNrLabel.AutoSize = true;
            this.bookArtNrLabel.Location = new System.Drawing.Point(6, 12);
            this.bookArtNrLabel.Name = "bookArtNrLabel";
            this.bookArtNrLabel.Size = new System.Drawing.Size(34, 13);
            this.bookArtNrLabel.TabIndex = 4;
            this.bookArtNrLabel.Text = "ArtNr: (6 digits, not starting with 0)";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(6, 66);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(38, 13);
            this.bookNameLabel.TabIndex = 5;
            this.bookNameLabel.Text = "Name: (Letters)";
            // 
            // bookPricelabel
            // 
            this.bookPricelabel.AutoSize = true;
            this.bookPricelabel.Location = new System.Drawing.Point(6, 119);
            this.bookPricelabel.Name = "bookPricelabel";
            this.bookPricelabel.Size = new System.Drawing.Size(34, 13);
            this.bookPricelabel.TabIndex = 6;
            this.bookPricelabel.Text = "Price: (Numbers, decimals allowed)";
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(6, 173);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.bookAuthorLabel.TabIndex = 7;
            this.bookAuthorLabel.Text = "Author: (Letters)";
            // 
            // bookAmount
            // 
            this.bookAmount.Location = new System.Drawing.Point(6, 243);
            this.bookAmount.Name = "bookAmount";
            this.bookAmount.Size = new System.Drawing.Size(59, 20);
            this.bookAmount.TabIndex = 20;
            // 
            // bookgameAmountLabel
            // 
            this.bookgameAmountLabel.AutoSize = true;
            this.bookgameAmountLabel.Location = new System.Drawing.Point(6, 227);
            this.bookgameAmountLabel.Name = "bookgameAmountLabel";
            this.bookgameAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.bookgameAmountLabel.TabIndex = 21;
            this.bookgameAmountLabel.Text = "Amount: (Numbers, 0 to 99999) ";
            // 
            // addTabs
            // 
            this.addTabs.Controls.Add(this.booktab);
            this.addTabs.Controls.Add(this.cdTab);
            this.addTabs.Controls.Add(this.dvdTab);
            this.addTabs.Controls.Add(this.gameTab);
            this.addTabs.Location = new System.Drawing.Point(18, 23);
            this.addTabs.Name = "addTabs";
            this.addTabs.SelectedIndex = 0;
            this.addTabs.Size = new System.Drawing.Size(251, 329);
            this.addTabs.TabIndex = 0;

        }
        //Sets event handlers on buttons
        public void setEventHandler()
        {

            addButton.Click += new EventHandler(wc.addClick);
            deliveryOk.Click += new EventHandler(wc.deliveryClick);
            removeOk.Click += new EventHandler(wc.removeClick);
        
        }

        //Get the active tab
        public String getActiveTab()
        {
            if (addTabs.SelectedTab == addTabs.TabPages[0])
            {
                return "Book";
            }
            if (addTabs.SelectedTab == addTabs.TabPages[1])
            {
                return "Cd";
            }
            if (addTabs.SelectedTab == addTabs.TabPages[2])
            {
                return "Dvd";
            }
            if (addTabs.SelectedTab == addTabs.TabPages[3])
            {
                return "Game";
            }

            return "None";

        }

        //To fetch ArtNr from field, depending on active tab. Checks if input consists of all numbers
        public int getProductArtNr()
        {
            if (addTabs.SelectedTab == addTabs.TabPages[0])
            {
                if (bookArtNr.Text != "")
                {
                    try
                    {
                        int bookArt = Convert.ToInt32(bookArtNr.Text);

                        return bookArt;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("ArtNr must consist of all numbers");
                    }
                }
               
            }
            if (addTabs.SelectedTab == addTabs.TabPages[1])
            {
                if (cdArtNr.Text != "")
                {
                    try
                    {
                        int cdArt = Convert.ToInt32(cdArtNr.Text);

                        return cdArt;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("ArtNr must consist of all numbers");
                    }
                }

            }
            if (addTabs.SelectedTab == addTabs.TabPages[2])
            {
                if (dvdArtNr.Text != "")
                {
                    try
                    {
                        int dvdArt = Convert.ToInt32(dvdArtNr.Text);

                        return dvdArt;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("ArtNr must consist of all numbers");
                    }
                }
                

            }
            if (addTabs.SelectedTab == addTabs.TabPages[3])
            {
                if (gameArtNr.Text != "")
                {
                    try
                    {
                        int gameArt = Convert.ToInt32(gameArtNr.Text);

                        return gameArt;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("ArtNr must consist of all numbers");
                    }
                }

            }
            return 0;
        }

        //To fetch name from add products field, depending on active tab. Checks if input is not empty and that
        //it does not contain a dot
        public String getProductName()
        {
            if (addTabs.SelectedTab == addTabs.TabPages[0])
            {
                if (bookName.Text != "" && !bookName.Text.Contains("."))
                {
                    String bName = bookName.Text;

                    return bName;
                }

            }
            if (addTabs.SelectedTab == addTabs.TabPages[1])
            {
                if (cdName.Text != "" && !cdName.Text.Contains("."))
                {
                    String cName = cdName.Text;

                    return cName;


                }
            }
                if (addTabs.SelectedTab == addTabs.TabPages[2])
                {
                    if (dvdName.Text != "" && !dvdName.Text.Contains("."))
                    {
                        String dName = dvdName.Text;

                        return dName;
                    }
                }
                if (addTabs.SelectedTab == addTabs.TabPages[3])
                {
                    if(gameName.Text != "" && !gameName.Text.Contains(".")){
                    String gName = gameName.Text;

                    return gName;
                    }


                }
                return "";
            }

        //To fetch price from add products field, depending on active tab. Checks if input is not empty, then tries to convert
        //input into double and return the value. If failed, an error message will be displayed
        public double getProductPrice()
        {
            if (addTabs.SelectedTab == addTabs.TabPages[0])
            {
                if (bookPrice.Text != "")
                {
                    try
                    {
                        double bPrice = Convert.ToDouble(bookPrice.Text);

                        return bPrice;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Price must be a number");
                    }
                }

            }
            if (addTabs.SelectedTab == addTabs.TabPages[1])
            {
                if (cdPrice.Text != "")
                {
                    try
                    {
                        double cPrice = Convert.ToDouble(cdPrice.Text);

                        return cPrice;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Price must be a number");
                    }
                }

            }
            if (addTabs.SelectedTab == addTabs.TabPages[2])
            {
                if (dvdPrice.Text != "")
                {
                    try
                    {
                        double dPrice = Convert.ToDouble(dvdPrice.Text);
                        return dPrice;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Price must be a number");
                    }
                }


            }
            if (addTabs.SelectedTab == addTabs.TabPages[3])
            {
                if (gamePrice.Text != "")
                {
                    try
                    {
                        double gPrice = Convert.ToDouble(gamePrice.Text);

                        return gPrice;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Price must be a number"); ;
                    }
                }

            }
            return 0;
        
        }

        //To fetch Author/Artist/Director/Producer from add products field, depending on active tab. 
        //Checks if input is not empty and that it does not contain a dot.
        public String getProductUnique()
        { 
        if (addTabs.SelectedTab == addTabs.TabPages[0])
            {
                if (bookAuthor.Text != "" && !bookAuthor.Text.Contains("."))
                {
                    String bAuthor = bookAuthor.Text;

                    return bAuthor;
                }

            }
            if (addTabs.SelectedTab == addTabs.TabPages[1])
            {
                if (cdArtist.Text != "" && !cdArtist.Text.Contains("."))
                {
                    String cAuthor = cdArtist.Text;

                    return cAuthor;


                }
            }
                if (addTabs.SelectedTab == addTabs.TabPages[2])
                {
                    if (dvdDirector.Text != "" && !dvdDirector.Text.Contains("."))
                    {
                        String dAuthor = dvdDirector.Text;

                        return dAuthor;
                    }
                }
                if (addTabs.SelectedTab == addTabs.TabPages[3])
                {
                    if (gameProducer.Text != "" && !gameProducer.Text.Contains("."))
                    {
                    String gAuthor = gameProducer.Text;

                    return gAuthor;
                    }


                }
                return "";
            }

        //To fetch amount from add products field, depending on active tab. Checks if input is not empty, then tries to convert
        //input into int32 and return the value. If failed, an error message will be displayed.
        public int getProductAmount()
        {
            if (addTabs.SelectedTab == addTabs.TabPages[0])
            {
                if (bookAmount.Text != "")
                {
                    try
                    {
                        int bookAm = Convert.ToInt32(bookAmount.Text);

                        return bookAm;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Amount must consist of all numbers");
                    }
                }

            }
            if (addTabs.SelectedTab == addTabs.TabPages[1])
            {
                if (cdAmount.Text != "")
                {
                    try
                    {
                        int cdAm = Convert.ToInt32(cdAmount.Text);

                        return cdAm;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Amount must consist of all numbers");
                    }
                }

            }
            if (addTabs.SelectedTab == addTabs.TabPages[2])
            {
                if (dvdAmount.Text != "")
                {
                    try
                    {
                        int dvdAm = Convert.ToInt32(dvdAmount.Text);

                        return dvdAm;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Amount must consist of all numbers");
                    }
                }


            }
            if (addTabs.SelectedTab == addTabs.TabPages[3])
            {
                if (gameAmount.Text != "")
                {
                    try
                    {
                        int gameAm = Convert.ToInt32(gameAmount.Text);

                        return gameAm;
                    }
                    catch (FormatException e)
                    {
                        getErrorMessage("Amount must consist of all numbers");
                    }
                }

            }
            return 0;
        }

        //To fetch artnr from delivery field. Checks if input is not empty, then tries to convert
        //input into int32 and return the value. If failed, an error message will be displayed.
        public int getDeliveryArtNr()
        {
            if (deliveryArtNr.Text != "")
            {
                try
                {
                    int deliveryArt = Convert.ToInt32(deliveryArtNr.Text);

                    return deliveryArt;
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

        //To fetch amount from delivery field. Checks if input is not empty, then tries to convert
        //input into int32 and return the value. If failed, an error message will be displayed.
        public int getDeliveryAmount()
        {
            if (deliveryAmount.Text != "")
            {
                try
                {
                    int deliveryAm = Convert.ToInt32(deliveryAmount.Text);

                    return deliveryAm;
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

        //To fetch artnr from remove product field. Checks if input is not empty, then tries to convert
        //input into int32 and return the value. If failed, an error message will be displayed.
        public int getRemoveArtNr()
        {

            if (removeArtNr.Text != "")
            {
                    try
                    {
                        int removeArt = Convert.ToInt32(removeArtNr.Text);

                        return removeArt;
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

        //Gets a messagebox that is used to display any error message
        public void getErrorMessage(String s)
        {
            MessageBox.Show(s);
        }

        //Updates the products list in the view
        public void updateProducts(String s)
        {
            Productbox.Text = s;

        }
        //
       
    }
}
