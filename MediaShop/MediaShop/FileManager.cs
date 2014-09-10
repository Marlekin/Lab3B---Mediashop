using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace MediaShop
{
    public class FileManager
    {
        //Variables
        private static FileManager instance = null;
        private StreamWriter sw = null;
        private String fileContent;
        private String product;
        private List<String> fileContents;

        //Constructor, private to allow for singleton pattern
        private FileManager()
        {
            fileContents = new List<string>();
        }

        //Attributes
        public String FileContent
        {
            get
            {
                return fileContent;

            }
        }

        //Method for instantiating the filemanager instance
        //Only instantiates of there is not an instance already.
        //Guarantees only one instance of the class
        public static FileManager getInstance()
        {
            if (instance == null)
            {
                instance = new FileManager();
            }

            return instance;

        }

        //Takes attributes of product and converts into a string. Checks if artnr or name already exists. If not, then product string is saved to file, 
        //filecontent list is cleared and reloaded and then sorted. If name/artnr check should fail, an error message will be displayed.
        public void convertAndSave(String type, int artnr, String name, double price, String unique, int amount)
        {
            product = Convert.ToString(type + ": " + artnr + " . " + name + " . " + price + " . " + unique + " . " + amount);


            if (!search(Convert.ToString(artnr)) && !search(Convert.ToString(name)))
            {
                save(product);


                fileContents.Clear();
                open();

                fileContents.Sort();
            }

            else
            {
                MessageBox.Show("Product with this artNr or name already exists");
            }




        }

        //First checks if the file is empty or not. Instansiates a streamwriter that either overwrites contents in file
        //or appends to it, depending on which. Then saves the incoming line to the file
        public void save(String s)
        {

            if (fileContents.Count <= 0)
            {

                sw = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\Inventory.txt");

            }

            if (fileContents.Count > 0)
            {

                sw = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\Inventory.txt", true);

            }

            sw.WriteLine(s);
            sw.Close();
        }

        //Instansiates a streamreader. Starts reading line by line and adding them to the list of filecontents.
        //When done, the list is sorted. Then the list is iterated through and a string version of the list
        //is appended to for each iteration. The streamreader is the closed.
        public void open()
        {
            StreamReader sr = null;
            String line;

            sr = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath) + "\\Inventory.txt");

            fileContent = "";

            while ((line = sr.ReadLine()) != null)
            {
                fileContents.Add(line);
            }

            fileContents.Sort();

            foreach (string c in fileContents)
            {

                fileContent += c + "\n";
            }


            sr.Close();

        }

        //Takes a string. Iterates through the list of filecontents, and checks if it contains the input string.
        //If yes, then true is returned. Else false is returned.
        public bool search(String s)
        {

            foreach (String c in fileContents)
            {
                if (c.Contains(s))
                {
                    return true;
                }
            }

            return false;

        }

        //Takes an artnr and an amount. First checks if filecontent contains the artnr. If yes, then 
        //a string array is instansiatien, as well as a streamwriter. Single string version of filecontent is reset.
        //Then iterates through the filecontents, if matching artnr is found the string on that position will be split,
        //existing amount will be added with incoming amount, then the string will be rebuilt. The list will be sorted
        //and all the lines will be saved to the file again. Then the streamwriter is closed.
        public void updatePost(String artnr, String amount)
        {
            int num1 = Convert.ToInt32(amount);
            int num2;
            int result;

            if (search(artnr))
            {
                String[] post = new String[5];

                sw = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\Inventory.txt");

                fileContent = "";


                for (int i = fileContents.Count - 1; i >= 0; i--)
                {

                    if (fileContents[i].Contains(artnr))
                    {

                        post = fileContents[i].Split('.');
                        num2 = Convert.ToInt32(post[4]);

                        result = num1 + num2;

                        post[4] = Convert.ToString(result);

                        fileContents[i] = post[0] + "." + post[1] + "." + post[2] + "." + post[3] + ". " + post[4];

                    }
                }

                fileContents.Sort();

                foreach (String c in fileContents)
                {
                    sw.WriteLine(c);

                    fileContent += c + "\n";
                }
            }
            else
            {
                MessageBox.Show("No product with that ArtNr stored");
            }

            sw.Close();

        }

        //Gets the list of filecontents
        public List<String> getProductList()
        {
            return fileContents;
        }

        //Takes an artnr. Instansiates a streamwriter. Then checks if filecontent contains the artnr. If yes, then 
        //the list of filecontents will be iterated through, and where a matching artnr is found a string will be
        //assigned the amount of the article in question. If the amount is not 0 then a message asking for confirmation
        //of removal will be shown. If yes, then the list of filecontents will be iterated through again and remove
        //the string where the artnr matches. The filecontents will then be sorted and then saved to file.
        //The streamwriter is the closed.
        public void remove(String s)
        {
            int post = 0;
            sw = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\Inventory.txt");

            if (search(s))
            {
                for (int i = fileContents.Count - 1; i >= 0; i--)
                {

                    if (fileContents[i].Contains(s))
                    {

                        post = Convert.ToInt32(fileContents[i].Split('.').Last());

                    }
                }

                fileContent = "";


                if (post != 0)
                {


                    if (MessageBox.Show("Amount is not 0, remove anyway", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        for (int i = fileContents.Count - 1; i >= 0; i--)
                        {

                            if (fileContents[i].Contains(s))
                            {

                                fileContents.RemoveAt(i);

                            }
                        }
                    }

                }
                else
                {
                    for (int i = fileContents.Count - 1; i >= 0; i--)
                    {

                        if (fileContents[i].Contains(s))
                        {

                            fileContents.RemoveAt(i);

                        }
                    }

                }

                fileContents.Sort();

                foreach (String c in fileContents)
                {
                    sw.WriteLine(c);

                    fileContent += c + "\n";
                }

            }
            else
            {
                MessageBox.Show("No product with that ArtNr stored");
            }

            sw.Close();
        }

        //Takes an artnr. Iterates through list of filecontents. Where a matching artnr is found, a string is assigned
        //the corresponding string from filecontents. The string is the returned.
        public String getProduct(String s)
        {
            String product = "";


            for (int i = fileContents.Count - 1; i >= 0; i--)
            {

                if (fileContents[i].Contains(s))
                {
                    product = fileContents[i];

                }
            }

            return product;
        }

        //Instansiates a printdocument and initiates it. Then instantiates a printdialog.
        //the dialog takes the printdocument as a basis for printing. The dialog is shown and waits for confirmation.
        //If confirmed, printing is attempted
        public void print(String s)
        {

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };

            PrintDialog pd = new PrintDialog();
            pd.Document = p;

            DialogResult result = pd.ShowDialog();

            if (result == DialogResult.OK)
            {

                try
                {
                    p.Print();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception Occured While Printing");
                }
            }

        }




    }
}
