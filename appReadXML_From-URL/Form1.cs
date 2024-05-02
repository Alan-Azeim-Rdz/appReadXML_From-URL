using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.LinkLabel;
using System.Security.Cryptography;
namespace appReadXML_From_URL
{
    public partial class Form1 : Form
    {
        ListViewItem lstv;
        String URLString;
        XmlTextReader reader;
        string[] lines = new string[36];
        int i = 0;
        int ix = 1;
        int dx = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string URL = txtURL.Text;
            URLString = URL;
            reader = new XmlTextReader(URLString);

            // Lista para almacenar los nombres de las columnas
            List<string> columnNames = new List<string>();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    // Obtiene el nombre del elemento
                    string element = reader.Value;
                    string name = reader.Name;

                    // Verifica si la columna ya ha sido agregada
                    if (!columnNames.Contains(name))
                    {
                        // Agrega la columna al ListView
                        lstvOrder.Columns.Add(name);

                        // Agrega el nombre de la columna a la lista
                        columnNames.Add(name);
                    }
                }

                
            }

            // Crea un nuevo lector XML desde la URL proporcionada
            using (XmlTextReader reader = new XmlTextReader(URL))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            string name = reader.Name;
                            txtXMLData.Text += ("<" + reader.Name);

                            while (reader.MoveToNextAttribute()) // Read the attributes.
                                txtXMLData.Text += (" " + reader.Name + "='" + reader.Value + "'");
                            //txtXMLData.Text +=(">");
                            txtXMLData.Text += (">") + Environment.NewLine;

                           
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            txtXMLData.Text += (reader.Value) + Environment.NewLine;
                            string textValue = reader.Value;
                            while (i == dx)
                            {
                                i += 8;
                                dx++;
                                lstv = new ListViewItem(Convert.ToString(dx));
                                lstvOrder.Items.Add(lstv);
                            }
                            while(ix == dx)
                            {
                                ix += 8;
                                dx++;
                                lstv.SubItems.Add("x");
                            }
                            dx++;
                            lstv.SubItems.Add(textValue);


                           

                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            txtXMLData.Text += ("</" + reader.Name);
                            txtXMLData.Text += (">") + Environment.NewLine;
                            break;

                    }

                }

            } 

        }
        
    }
}
