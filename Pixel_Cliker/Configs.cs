using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Pixel_Cliker
{
    public class Configs
    {
        public string path { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public string click { get; set; }
        public string typeScan { get; set; }
        public string intervalClick { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Configs()
        {
        }

        public Configs(string path)
        {
            path += @"\config.xml";
            this.path = path;

            if (File.Exists(path))
            {
                XmlTextReader xtr = new XmlTextReader(path);

                try
                {
                    while (xtr.Read())
                    {
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "x")
                            posX = Convert.ToInt32(xtr.ReadElementContentAsString());
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "y")
                            posY = Convert.ToInt32(xtr.ReadElementContentAsString());

                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "click")
                            click = xtr.ReadElementContentAsString();
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "type")
                            typeScan = xtr.ReadElementContentAsString();
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "y2")
                            intervalClick = xtr.ReadElementContentAsString();

                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "R")
                            R = Convert.ToInt32(xtr.ReadElementContentAsString());
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "G")
                            G = Convert.ToInt32(xtr.ReadElementContentAsString());
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "B")
                            B = Convert.ToInt32(xtr.ReadElementContentAsString());
                    }
                }
                catch { }

                xtr.Dispose();
                xtr.Close();

            }
            else
            {
                Save();
            }
        }

        public void Save()
        {
            using (var xWriter = new XmlTextWriter(path, Encoding.UTF8))
            {
                xWriter.Formatting = Formatting.Indented;
                xWriter.WriteStartElement("Configs");

                xWriter.WriteStartElement("x");
                xWriter.WriteString(posX.ToString());
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("y");
                xWriter.WriteString(posY.ToString());
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("click");
                xWriter.WriteString(click);
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("type");
                xWriter.WriteString(typeScan);
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("interval");
                xWriter.WriteString(intervalClick);
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("R");
                xWriter.WriteString(R.ToString());
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("G");
                xWriter.WriteString(G.ToString());
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("B");
                xWriter.WriteString(B.ToString());
                xWriter.WriteEndElement();

                xWriter.WriteEndElement();
            }           
        }
    }
}
