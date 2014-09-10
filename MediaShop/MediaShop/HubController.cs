using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaShop
{
    class HubController
    {
        //Variables
        FileManager _fm;
        CashierView _cv;
        WarehouseView _wv;

        //Constructor
        public HubController(FileManager fm, CashierView cv, WarehouseView wv)
        {
            _fm = fm;
            _cv = cv;
            _wv = wv;
        }


        //When the hub loads the products file will be opened and both WarehouseView and CashierView will be updated
        //with the filecontents
        public void onLoad(Object sender, EventArgs e)
        {
            _fm.open();
            _wv.updateProducts(_fm.FileContent);
            _cv.updateProducts(_fm.FileContent);
        }

        //On change of tab/view both WarehouseView and CashierView will be updated
        //with the filecontents
        public void onChange(Object sender, EventArgs e)
        {
            _wv.updateProducts(_fm.FileContent);
            _cv.updateProducts(_fm.FileContent);
        }
    }

}
