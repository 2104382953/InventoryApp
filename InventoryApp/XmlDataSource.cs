using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryApp
{
    public class XmlDataSource
    {
        BindingList<Inventory> InventoryList;
        private string strDataSource = Environment.CurrentDirectory + "\\InventoryData.xml";
       

        public XmlDataSource()
        {

        }

        //OverLoading
        public XmlDataSource(BindingList<Inventory> inventorylist)
        {
            InventoryList = inventorylist;
        }


        public void SaveXML()
        {
            var xElement = new XElement("InventoryList",
                from inventory in InventoryList
                select new XElement("InventoryItem",
                            new XAttribute("ID", inventory.ID),
                                new XElement("Name", inventory.Name),
                                new XElement("Description", inventory.Description)
                            ));

            xElement.Save(strDataSource);

        }


 

        public BindingList<Inventory> GetXmlIntoList()
        {
            XElement xmlData = XElement.Load(strDataSource);

            var xmlDataList = xmlData.Elements("InventoryItem")
                            .Select(x => new Inventory()
                            {
                                ID = (int)x.Attribute("ID"),
                                Name = (string)x.Element("Name")
                            }).ToList();


            //Assiging the value to our list
            InventoryList = new BindingList<Inventory>(xmlDataList);
            return InventoryList;
        }
    }
}
