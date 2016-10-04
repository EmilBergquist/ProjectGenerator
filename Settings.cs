using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjektGenerator_Test1
{
    class Settings
    {
        public void SavePropSettings()
        { 
           
            //Kod för att använda xml för att spara inställningar istället.

            //XmlDocument doc = new XmlDocument();

            //XmlElement element1 = doc.CreateElement(string.Empty, "Settings", string.Empty);
            //doc.AppendChild(element1);

            //XmlElement element2 = doc.CreateElement(string.Empty, "Setting1", string.Empty);
            //XmlText text1 = doc.CreateTextNode("Setting1 text");
            //element1.AppendChild(element2);
            //element2.AppendChild(text1);

            //XmlElement element3 = doc.CreateElement(string.Empty, "Setting2", string.Empty);
            //XmlText text2 = doc.CreateTextNode("Setting2 text");
            //element1.AppendChild(element3);
            //element3.AppendChild(text2);

            //doc.Save("~\\Settings.xml");
        }

        public void loadSettings()
        {
            
            //Kod för att använda xml för att hitta inställningar.

            //XmlDocument Doc = new XmlDocument();

            //Doc.Load("~\\Settings.xml");

            //XmlNode setting1Node = Doc.SelectSingleNode("/Settings/Setting1");
            //textBlock.Text = setting1Node.InnerText;

            //XmlNode setting2Node = Doc.SelectSingleNode("/Settings/Setting2");
            //textBlock1.Text = setting2Node.InnerText;
        }

        public void openSettingsWindow()
        {
            SettingsWindow setWin = new SettingsWindow();

            setWin.ShowDialog();
        }
    }
}
