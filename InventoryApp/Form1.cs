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

        //public void xmlWrite()
        //{
        //    Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\File.xml");
        //    XmlSerializer xmlSer = new XmlSerializer(typeof(BindingList<string>));
        //    //We are now putting everything together.  We are using the Serialize process to pass our configuration and the list of person.
        //    xmlSer.Serialize(stream, inventoryList);
        //    //we need to close our stream
        //    stream.Close();

        //    Console.WriteLine(Environment.CurrentDirectory);
        //}

        //public void nodeRemove()
        //{
        //    XmlDocument inventoryList = new XmlDocument();

        //    inventoryList.Load(Environment.CurrentDirectory + "\\File.xml");

        //    XmlNodeList list = inventoryList.SelectNodes("//*[not(string(.))]");
        //        foreach (XmlNode node in list)
        //        {
        //            node.ParentNode.RemoveChild(node);
        //        }
        //     inventoryList.Save(Environment.CurrentDirectory + "\\File.xml");
        //}

        private void btnAddInventory_Click(object sender, EventArgs e)
        {

            Inventory inventoryItem = new Inventory();
            inventoryItem.ID = InventoryList.Count > 0 ? InventoryList.Max(x => x.ID) + 1 : 1;
            inventoryItem.Name = inputBox.Text;
            InventoryList.Add(inventoryItem);

            //Saving the data
            //XmlDataSource xmldatasource = new XmlDataSource(InventoryList);
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

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    var selectedValue = lstBoxInventory.GetItemText(lstBoxInventory.SelectedItem);
        //    BindingList<Inventory> queryResults = new BindingList<Inventory>(InventoryList.Where(x => x.Name == selectedValue).ToList());

        //    xmldatasource.UpdateXML(queryResults);
        //}
    }
}
