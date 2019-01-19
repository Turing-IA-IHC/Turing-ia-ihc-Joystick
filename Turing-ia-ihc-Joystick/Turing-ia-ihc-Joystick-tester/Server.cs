using System;
using System.Windows.Forms;
using Turing_ia_ihc_Joystick;

namespace Turing_ia_ihc_Joystick_tester
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        static JoystickServer j = new JoystickServer();

        private void Server_Load(object sender, EventArgs e)
        {
            j.DataReceived += J_DataReceived;
        }

        private void J_DataReceived(object sender, Data e)
        {
            this.txtMessageReceived.Text += 
                string.Format("\r\n{0}|{1}=>{2}", e.Time, e.IPSource, e.Message);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string nl = "\r\n";
            this.btnOpen.Text = "Wainting...";
            this.Refresh();
            
            j.Config((int)this.txtPort.Value);
            j.InitialMessage = nl + "====== Wellcome to here. ======" + nl;
            j.InitialMessage += "Please send message on this JSON structure:" + nl;
            j.InitialMessage += "{ id:int, X:int, Y:int, Velocidad:float where 1 is a meter, Momento:date time en forma yyyyMMddHHmmss.ms }" + nl;
            j.InitialMessage += "{ id:1, X:50, Y:50, Momento:201911301525.5 }" + nl;            
            j.Toggle();
            this.btnOpen.Text = j.isOpen ? "&Close" : "&Open";
            this.btnSend.Enabled = j.isOpen;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            j.Send(this.txtMessageToSend.Text);
            this.txtMessageToSend.Text = "";
        }
    }
}
