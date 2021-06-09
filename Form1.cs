using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testControler
{
    public partial class Form1 : Form
    {
        string serverIP = "192.168.0.154";
        int port = 9001;

        Socket socket = null;

        public Form1()
        {
            InitializeComponent();

            // 소켓 연결
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(serverIP, port);

        }

        private void Btn_Foward_Click(object sender, EventArgs e)
        {
            string message = "w";

            socket.Send(Encoding.Default.GetBytes(message));
        }

        private void Btn_Left_Click(object sender, EventArgs e)
        {
            string message = "a";
            socket.Send(Encoding.Default.GetBytes(message));
        }

        private void Btn_Backword_Click(object sender, EventArgs e)
        {
            string message = "s";
            socket.Send(Encoding.Default.GetBytes(message));
        }

        private void Btn_Right_Click(object sender, EventArgs e)
        {
            string message = "d";
            socket.Send(Encoding.Default.GetBytes(message));
        }
    }
}
