using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turing_ia_ihc_Joystick;

namespace Turing_ia_ihc_Joystick_tester
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        static JoystickClient j = new JoystickClient();

        private void Client_Load(object sender, EventArgs e)
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
            this.btnOpen.Text = "Wainting...";
            this.Refresh();

            j.Config(this.txtServerAddress.Text, (int)this.txtServerPort.Value);
            j.Toggle();
            this.btnOpen.Text = j.isOpen ? "&Close" : "&Open";
            this.btnSend.Enabled = j.isOpen;
            this.btnContenctFile.Enabled = j.isOpen;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            j.Send(this.txtMessageToSend.Text);
            this.txtMessageToSend.Text = "";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog(this) == DialogResult.OK)
            {
                this.txtFile.Text = ofdFile.FileName;
            }
        }

        private async void btnContenctFile_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.txtFile.Text))
            {
                string[] Lines = System.IO.File.ReadAllLines(this.txtFile.Text);
                foreach (string item in Lines)
                {
                    j.Send(item);
                    await Task.Delay(1);
                }
            }
            else
            {
                MessageBox.Show("File don't exists.");
            }
        }
    }
}
