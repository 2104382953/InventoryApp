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
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {

            Inventory inventoryItem = new Inventory();
            inventoryItem.ID = InventoryList.Count > 0 ? InventoryList.Max(x => x.ID) + 1 : 1;
            inventoryItem.Name = inputBox.Text;
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
        }
    }
}
