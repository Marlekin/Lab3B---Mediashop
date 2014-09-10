using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class Hub : Form
    {
        //Variables
        private CashierView _c;
        private WarehouseView _w;
        private HubController _hc;

        //Constructor
        //Instansiates WarehouseView and CashierView and connects them to filemanager and 
        //the hub controller aswell, along with the filemanager. Connects event handlers to onload events and 
        //tab change events to enable opening of file and view updates in each corresponding view when 
        //loading the program and switching between views.
        public Hub()
        {

            FileManager fm = FileManager.getInstance();


            InitializeComponent();


            _c = new CashierView(fm); 
            _w = new WarehouseView(fm);

            HubController _hc = new HubController(fm, _c, _w);

            Cashier.Controls.Add(_c);
            Warehouse.Controls.Add(_w);

            this.Load += new EventHandler(_hc.onLoad);
            TabMenu.Selected += new TabControlEventHandler(_hc.onChange);


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        
       
    }
}
