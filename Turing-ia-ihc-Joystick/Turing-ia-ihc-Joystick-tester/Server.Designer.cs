namespace Turing_ia_ihc_Joystick_tester
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMessageReceived = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageToSend = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessageReceived);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtMessageToSend);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // txtMessageReceived
            // 
            this.txtMessageReceived.AcceptsReturn = true;
            this.txtMessageReceived.AcceptsTab = true;
            this.txtMessageReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageReceived.Location = new System.Drawing.Point(6, 72);
            this.txtMessageReceived.Multiline = true;
            this.txtMessageReceived.Name = "txtMessageReceived";
            this.txtMessageReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageReceived.Size = new System.Drawing.Size(264, 83);
            this.txtMessageReceived.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(199, 43);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageToSend
            // 
            this.txtMessageToSend.Location = new System.Drawing.Point(6, 46);
            this.txtMessageToSend.Name = "txtMessageToSend";
            this.txtMessageToSend.Size = new System.Drawing.Size(187, 20);
            this.txtMessageToSend.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(50, 20);
            this.txtPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(54, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Value = new decimal(new int[] {
            53211,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(199, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 161);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMessageReceived;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageToSend;
        private System.Windows.Forms.NumericUpDown txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
    }
}