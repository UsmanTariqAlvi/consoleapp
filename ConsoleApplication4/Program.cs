using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 22000842; //220010516;  
            XmlTextWriter writer = new XmlTextWriter("product.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            Dictionary<string,string> list = new Dictionary<string,string>();
            list.Add("CARD_HOLDER_PRESENT","1");
            list.Add("CARD_PRESENT","1");
            list.Add("CONTACT_PERSON_CITY","Karachi");
            list.Add("CONTACT_PERSON_COUNTRY","11");
            list.Add("CONTACT_PERSON_EMAIL","jonsnow@hotmail.com");
            list.Add("CONTACT_PERSON_NAME","Jon");
            list.Add("CONTACT_PERSON_PHONE","03333322110");
            list.Add("CONTACT_PERSON_ZIP_CODE","231231");
            list.Add("ENTRY_MODE","01");
            list.Add("FIRMWARE","v5111");
            list.Add("MANUFACTURER_NAME","1");
            list.Add("MERCHANT_ID","000010022211154");
            list.Add("MODEL_NUMBER","T2100");
            list.Add("POS_ID", "220010115");
            list.Add("SERIAL_NUMBER","00124515");
            list.Add("TERMINAL_CAPABILITY","00");
            list.Add("SCHEME","1");
            list.Add("TERMINAL_ENTRY_CAPABILITY","0");
            list.Add("TERMINAL_PREMISES","1");
            list.Add("CARD_RETENTION","0");
            list.Add("CAT_INDICATOR","1");
            list.Add("DATE_LAST_UPDATED","20170101000000");
            list.Add("ENCRYPTION_PROTOCOL","abcd");
            list.Add("CURRENCY","586");
            list.Add("TERMINAL_TYPE","1");
            for (int i = 1; i <= 200; i++)
            {
                count++;
                writer.WriteStartElement("POSEntity");
                for (int j = 0; j < 25; j++)
                {
                    createNode(list.ElementAt(j).Key, list.ElementAt(j).Key != "POS_ID" ? list.ElementAt(j).Value : count.ToString(), writer);
                }
                    writer.WriteEndElement();
            }
                writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public static void createNode(string elementName,string elementValue, XmlTextWriter writer)
        {
            writer.WriteStartElement(elementName);
            writer.WriteString(elementValue);
            writer.WriteEndElement();
        }
    }
}
