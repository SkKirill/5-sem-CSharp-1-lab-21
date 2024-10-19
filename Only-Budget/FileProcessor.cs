using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lb6
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
    class FileProcessorDat : IFileProcessor
    {
        public List<Students> Load(string filename)
        {
            List<Students> students = new List<Students>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    students = (List<Students>)formatter.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return students;
        }

        public void Save(string filename, List<Students> students)
        {
            if (students.Count == 0)
            {
                return;
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(fs, students);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
