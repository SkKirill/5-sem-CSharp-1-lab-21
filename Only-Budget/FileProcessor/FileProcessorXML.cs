using Lb6.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Lb6.FileProcessor
{
	class FileProcessorXML : IFileProcessor
    {
        public List<Students> Load(string filename)
        {
            List<Students> students = new List<Students>();
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(List<Students>));
            if (fs.Length > 0)
            {
                students = (List<Students>)xml.Deserialize(fs);
            }
            fs.Close();
            return students;
        }

        public void Save(string filename, List<Students> students)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Students>));
            TextWriter sw = new StreamWriter(filename);
            xml.Serialize(sw, students);
            sw.Close();
        }
    }
}
