using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ToDoList
{
    public class Serializator
    {
        private static XmlSerializer serializator;

        public static void Serialize(Type type, object o, string fileToSave)
        {
            serializator = new XmlSerializer(type);

            try
            {
                using (FileStream fs = new FileStream(fileToSave + ".xml", FileMode.Create))
                {
                    serializator.Serialize(fs, o);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static object Deserialize(Type type, string fileFrom)
        {
            serializator = new XmlSerializer(type);
            try
            {
                using (FileStream fs = new FileStream(fileFrom + ".xml", FileMode.Open))
                {
                    return serializator.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
