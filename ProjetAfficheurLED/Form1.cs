using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetAfficheurLED
{
    public partial class Form1 : Form
    {
        TcpSocket tcpSocket = new TcpSocket();

        int size = 18;
        int columns = 44;
        int rows = 11;

        PictureBox[] tabLed;
        Color backgroundColor = Color.White;
        Color selectedColor = Color.Blue;
        int[] ledValue;

        string folderName = @"C:\MessagesLED";

        public Form1()
        {
            InitializeComponent();
            tabLed = new PictureBox[rows * columns];
            ledValue = new int[rows * columns];
            for (int iIndex = 0; iIndex < tabLed.Length; iIndex++)
            {
                ledValue[iIndex] = 0;
                tabLed[iIndex] = new PictureBox();
                tabLed[iIndex].Name = iIndex.ToString();
                tabLed[iIndex].Location = new Point(6 + (iIndex * size % (columns * size)), 6 + size * (iIndex * size / (columns * size)));
                tabLed[iIndex].Size = new Size(size, size);
                tabLed[iIndex].BackColor = backgroundColor;
                tabLed[iIndex].BorderStyle = BorderStyle.Fixed3D;
                tabLed[iIndex].MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                panelLed.Controls.Add(tabLed[iIndex]);
            }

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            foreach (string file in Directory.GetFiles(folderName))
            {
                listFiles.Items.Add(Path.GetFileName(file));
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string data = "";
            foreach (int value in ledValue)
            {
                data += value.ToString();
            }

            tcpSocket.SendMessage(data);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            PictureBox picutreBox = (PictureBox)sender;
            if (ledValue[Array.IndexOf(tabLed, picutreBox)] == 0)
            {
                picutreBox.BackColor = selectedColor;
                ledValue[Array.IndexOf(tabLed, picutreBox)] = 1;
            }
            else
            {
                picutreBox.BackColor = backgroundColor;
                ledValue[Array.IndexOf(tabLed, picutreBox)] = 0;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string fileName = folderName + @"\" + textFileName.Text + ".data";
            string data = "";
            foreach (int value in ledValue)
            {
                data += value.ToString();
            }

            if ( textFileName.Text == "")
            { 
                MessageBox.Show("Nom de fichier vide");
            }
            else if (!File.Exists(fileName) && textFileName.Text != "")
            {
                File.WriteAllText(fileName, data);
                listFiles.Items.Add(Path.GetFileName(fileName));
                MessageBox.Show("Fichier sauvegardé");
            }
            else
            {
                MessageBox.Show("Ce fichier existe déjà");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string fileName = folderName + @"\" + listFiles.GetItemText(listFiles.SelectedItem);
            if (File.Exists(fileName))
            {
                string data = File.ReadAllText(fileName);
                for (int i = 0; i < data.Length; i++)
                {
                    int value = int.Parse(data[i].ToString());
                    PictureBox picutreBox = tabLed[i];

                    if (value == 1)
                    {
                        picutreBox.BackColor = selectedColor;
                        ledValue[i] = 1;
                    }
                    else
                    {
                        picutreBox.BackColor = backgroundColor;
                        ledValue[i] = 0;
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string fileName = folderName + @"\" + listFiles.GetItemText(listFiles.SelectedItem);
            if (File.Exists(fileName))
            {
                try
                {
                    File.Delete(fileName);
                    listFiles.Items.Remove(listFiles.SelectedItem);
                }
                catch (IOException ex)
                {
                    // Gérer les exceptions liées à la suppression du fichier
                    MessageBox.Show("Une erreur s'est produite lors de la suppression du fichier : " + ex.Message);
                }
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Réinitialiser les valeurs des LED à 0
            for (int i = 0; i < ledValue.Length; i++)
            {
                ledValue[i] = 0;
                tabLed[i].BackColor = backgroundColor;
            }
        }


    }
}
