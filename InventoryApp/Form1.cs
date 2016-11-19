using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace InventoryApp
{
    public partial class Form1 : Form
    {
        public BindingList<Inventory> InventoryList;
        XmlDataSource xmldatasource = new XmlDataSource();

        public Form1()
        {
            InitializeComponent();

            InventoryList = xmldatasource.GetXmlIntoList();

            lstBoxInventory.DataSource = InventoryList;
            lstBoxInventory.DisplayMember = "Name";
            //lstBoxInventory.DisplayMember = "Description";
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {

            Inventory inventoryItem = new Inventory();

            //Replaced y line 52
            /*if(InventoryList.Count > 0)
            {
                inventoryItem.ID = InventoryList.Max(x => x.ID) + 1;
            }else
            {
                inventoryItem.ID = 1;
            }*/

            /*
             * This section only assigns a numberical value for the ID attribute
             Lines 37 - 43 are the same as line 49.
             ? replaces if
             : replaces else
             inventoryItemID = (The condition if true)?(The value assigned if true):(The value assigned if false) 
             */
            inventoryItem.ID = InventoryList.Count > 0 ? InventoryList.Max(x => x.ID) + 1 : 1;
            
            inventoryItem.Name = inputBox.Text;
            inventoryItem.Description = txtDescription.Text;

            InventoryList.Add(inventoryItem);

            //Saving the data
            xmldatasource.SaveXML();
            
        }

        private void btnRemoveInventory_Click(object sender, EventArgs e)
        {

            var inventoryItem = InventoryList.Where(x => x.Name == inputBox.Text).SingleOrDefault();
            InventoryList.Remove(inventoryItem);

            //Saving the data
            XmlDataSource xmldatasource = new XmlDataSource(InventoryList);
            xmldatasource.SaveXML();
        }

        private void lstBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputBox.Text = lstBoxInventory.GetItemText(lstBoxInventory.SelectedItem);

            /*
             * Build a custom query to get the description based on the item name
             * Logic:
             * Check if InventoryList is empty before running the query.
             * Once you run the query, check if the result is not emtpy/null
             */
            if (InventoryList != null)
            {
                var result = InventoryList.Where(x => x.Name == inputBox.Text).FirstOrDefault();

                if (result != null)
                    txtDescription.Text = result.Description.ToString();
            }
        }
    }
}
