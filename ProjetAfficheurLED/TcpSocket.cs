using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace ProjetAfficheurLED
{
    class TcpSocket
    {
        String host = "127.0.0.1";
        int port = 4444;
        IPEndPoint ip;

        public TcpSocket()
        {
            this.ip = new IPEndPoint(IPAddress.Parse(host), port);
        }

        public void SendMessage(string message)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ip);
            }
            catch (SocketException e)
            {

                MessageBox.Show("Connexion echouée");
                return;
            }

            //Try catch
            server.Send(Encoding.ASCII.GetBytes(message));
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }
    }
}
