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
        int col = 44;
        int line = 11;

        PictureBox[] tabLed;
        Color backgroundColor = Color.White;
        Color selectedColor = Color.Blue;
        int[] ledValue;

        public Form1()
        {
            InitializeComponent();
            tabLed = new PictureBox[line * col];
            ledValue = new int[line * col];
            for (int iIndex = 0; iIndex < tabLed.Length; iIndex++)
            {
                ledValue[iIndex] = 0;
                tabLed[iIndex] = new PictureBox();
                tabLed[iIndex].Name = iIndex.ToString();
                tabLed[iIndex].Location = new Point(6 + (iIndex * size % (col * size)), 6 + size * (iIndex * size / (col * size)));
                tabLed[iIndex].Size = new Size(size, size);
                tabLed[iIndex].BackColor = backgroundColor;
                tabLed[iIndex].BorderStyle = BorderStyle.Fixed3D;
                tabLed[iIndex].MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                panelLed.Controls.Add(tabLed[iIndex]);
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
